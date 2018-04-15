using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UGUIEditor
{
    [MenuItem("UI/Build AB")]
    public static void BuildAB()
    {
        BuildPipeline.BuildAssetBundles("AB", BuildAssetBundleOptions.ChunkBasedCompression | BuildAssetBundleOptions.ForceRebuildAssetBundle, BuildTarget.StandaloneWindows);
    }

}
