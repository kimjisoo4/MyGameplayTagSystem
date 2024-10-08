﻿#if SCOR_ENABLE_VISUALSCRIPTING
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using Unity.VisualScripting;
using StudioScor.GameplayTagSystem.Editor;


namespace StudioScor.GameplayTagSystem.Extend.VisualScripting.Editor
{
    public static class GameplayTagSystemPathUtilityWithVisualScripting
    {
        public static string VisualScriptingResources => GameplayTagSystemPathUtility.RootFolder + "Extend/WithVisualScripting/Editor/Icons/";

        private readonly static Dictionary<string, EditorTexture> _EditorTextures = new Dictionary<string, EditorTexture>();

        public static EditorTexture Load(string name)
        {
            if (_EditorTextures.ContainsKey(name))
            {
                return GetStateTexture(name);
            }

            var _path = VisualScriptingResources;

            var editorTexture = EditorTexture.Single(AssetDatabase.LoadAssetAtPath<Texture2D>(_path + name + ".png"));

            _EditorTextures.Add(name, editorTexture);

            return GetStateTexture(name);
        }

        private static EditorTexture GetStateTexture(string name)
        {
            return _EditorTextures[name];
        }
    }
}
#endif