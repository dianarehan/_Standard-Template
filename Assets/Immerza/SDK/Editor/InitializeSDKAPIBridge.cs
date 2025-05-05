using ImmerzaSDK.Manager.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
internal static class InitializeSDKAPIBridge
{
    static InitializeSDKAPIBridge()
    {
        Log.LogInfo("Setting up SDK bridge", LogChannelType.SDK);
        SDKAPIBridge.RegisterSceneBuilder(ScriptableObject.CreateInstance<SceneBuilder>());
    }
}
