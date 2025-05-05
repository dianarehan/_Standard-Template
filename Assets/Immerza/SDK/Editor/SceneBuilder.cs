using ImmerzaSDK;
using ImmerzaSDK.Manager.Editor;
using ImmerzaSDK.Types;
using ImmerzaSDK.Util;
using SharpCompress.Common;
using SharpCompress.Writers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

internal class SceneBuilder : ScriptableObject, ISceneBuilder
{
    [SerializeField]
    private TextAsset _dummyFile = null;

    public bool PrepareForExport(ExportSettings exportSettings)
    {
        Log.LogInfo($"Start exporting scene {exportSettings.SceneToExport.name}", LogChannelType.SDK);

        ImmerzaUtil.InitCrcTable();

        try
        {
            EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(exportSettings.SceneToExport));
        }
        catch (ArgumentException e)
        {
            Log.LogError($"Failed to open export scene with {e.Message}", LogChannelType.SDK);
            return false;
        }

        return true;
    }

    public bool ExportScene(ExportSettings exportSettings)
    {
        string bundleDir = Path.Combine(Path.GetDirectoryName(Application.dataPath), exportSettings.ExportFolder);
        Log.LogInfo($"\tExport target {bundleDir}", LogChannelType.SDKManager);
        if (!Directory.Exists(bundleDir))
        {
            Directory.CreateDirectory(bundleDir);
        }

        string scenePath = SceneManager.GetActiveScene().path;
        AssetMetadata assetMetadata = new();
        assetMetadata.AddAsset("ImmerzaScene", scenePath);

        List<string> assetPaths = new();
        ImmerzaUtil.AddAssetPath(assetPaths, AssetDatabase.GetAssetPath(_dummyFile));
        assetMetadata.AddAsset("Gen", "NONE");

        AssetBundleBuild[] exportMap = new AssetBundleBuild[2];
        exportMap[0].assetBundleName = "immerza_scene";
        exportMap[0].assetNames = new[] { scenePath };
        exportMap[1].assetBundleName = "immerza_assets";
        exportMap[1].assetNames = assetPaths.ToArray();

        SceneMetadata sceneMetadata = new();
        sceneMetadata.sdkVersion = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Immerza/Version.txt").ToString();

        bool bundlesCreated = true;
        bundlesCreated  = ExportBundles(exportSettings, bundleDir, exportMap, sceneMetadata, assetMetadata, BuildTarget.Android);
        bundlesCreated &= ExportBundles(exportSettings, bundleDir, exportMap, sceneMetadata, assetMetadata, BuildTarget.StandaloneWindows64);
        sceneMetadata.SaveMetaData(Path.Combine(bundleDir, "immerza_metadata.json"));

        if (bundlesCreated)
            Log.LogInfo("\tFinished successfully", LogChannelType.SDKManager);
        else
            Log.LogWarning("\tFailed", LogChannelType.SDKManager);

        return bundlesCreated;
    }

    private bool ExportBundles(ExportSettings exportSettings, string bundleDir, AssetBundleBuild[] exportMap, SceneMetadata sceneMetadata, AssetMetadata assetMetadata, BuildTarget platform)
    {
        BuildPipeline.BuildAssetBundles(bundleDir, exportMap, BuildAssetBundleOptions.ForceRebuildAssetBundle, platform);
        sceneMetadata.assetMetaData = assetMetadata;

        string platformId = platform == BuildTarget.Android ? "android" : "win";

        sceneMetadata.isUsingBgMusic = UnityEngine.Object.FindAnyObjectByType<BackgroundAudio>(FindObjectsInactive.Include) != null;

        Log.LogInfo($"\tExport bundle for {platformId}...", LogChannelType.SDK);

        try
        {
            File.Delete(Path.Combine(bundleDir, exportSettings.ExportFolder));
            File.Delete(Path.Combine(bundleDir, exportSettings.ExportFolder + ".manifest"));
            File.Delete(Path.Combine(bundleDir, "immerza_scene.manifest"));
            File.Delete(Path.Combine(bundleDir, "immerza_assets.manifest"));

            string archivePath = Path.Combine(bundleDir, "immerza_scene_" + platformId + ".bundle");

            if (File.Exists(archivePath))
            {
                File.Delete(archivePath);
            }

            using (Stream stream = File.OpenWrite(archivePath))
            using (IWriter writer = WriterFactory.Open(stream, ArchiveType.Tar, SharpCompress.Common.CompressionType.GZip))
            {
                writer.Write("immerza_scene.bundle", Path.Combine(bundleDir, "immerza_scene"));
                writer.Write("immerza_assets.bundle", Path.Combine(bundleDir, "immerza_assets"));
            }

            byte[] dataScene = File.ReadAllBytes(Path.Combine(bundleDir, "immerza_scene"));
            byte[] dataAssets = File.ReadAllBytes(Path.Combine(bundleDir, "immerza_assets"));

            byte[] combined = new byte[dataScene.Length + dataAssets.Length];
            Buffer.BlockCopy(dataScene, 0, combined, 0, dataScene.Length);
            Buffer.BlockCopy(dataAssets, 0, combined, dataScene.Length, dataAssets.Length);

            uint crc = 0xffffffff;
            crc = ImmerzaUtil.ComputeChecksum(combined);

            sceneMetadata.platforms.Add(new PlatformInfo(platformId, crc));

            File.Delete(Path.Combine(bundleDir, "immerza_scene"));
            File.Delete(Path.Combine(bundleDir, "immerza_assets"));
        }
        catch (Exception exc)
        {
            Log.LogError($"\t...failed with {exc.Message}", LogChannelType.SDK);

            System.IO.DirectoryInfo di = new(bundleDir);
            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.EnumerateDirectories())
            {
                dir.Delete(true);
            }

            return false;
        }

        Log.LogInfo($"\t...done", LogChannelType.SDK);

        return true;
    }
}
