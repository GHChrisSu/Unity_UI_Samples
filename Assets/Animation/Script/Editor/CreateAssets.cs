using UnityEngine;
using UnityEditor;
using System;
public class CreateAssets
{
    [MenuItem("Assets/Create assets")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<AnimatorParameter>();
    }
}