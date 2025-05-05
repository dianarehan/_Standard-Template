using ImmerzaSDK.Lua;
using ImmerzaSDK.Manager.Editor;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public static class LuaScriptDragAndDrop
{
    [InitializeOnLoadMethod]
    public static void RegisterDragAndDropInspector()
    {
        DragAndDrop.AddDropHandler(OnHandleDropAction);
    }

    private static DragAndDropVisualMode OnHandleDropAction(Object[] targets, bool perform)
    {
        List<GameObject> targetGameObjects = new();
        foreach (var target in targets)
            if (target is GameObject gameObject && gameObject.GetComponent<SpriteRenderer>() == null)
                targetGameObjects.Add(gameObject);

        if (targetGameObjects.Count == 0)
        {
            return DragAndDropVisualMode.None;
        }

        LuaAsset luaAsset = new();
        foreach (Object item in DragAndDrop.objectReferences)
        {
            if (item is LuaAsset scriptableObject)
            {
                luaAsset = scriptableObject;
                break;
            }
        }

        if (luaAsset == null)
        {
            return DragAndDropVisualMode.None;
        }

        if (perform)
        {
            foreach (GameObject gameObject in targetGameObjects)
            {
                LuaComponent luaComponent = Undo.AddComponent<LuaComponent>(gameObject);
                FieldInfo mainLuaScriptField = typeof(LuaComponent).GetField("mainLuaScript", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if (mainLuaScriptField != null)
                {
                    mainLuaScriptField.SetValue(luaComponent, luaAsset);
                }
                else
                {
                    Log.LogError("Couldn't attach Lua script to game object. Property 'mainLuaScript' not found. Was it renamed?", LogChannelType.SDK);
                }
            }
        }

        return DragAndDropVisualMode.Link;
    }
}
