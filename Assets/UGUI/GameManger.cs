using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var m = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "AB"));
        AssetBundleManifest am = m.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        var dp = am.GetAllDependencies("ui");
        Debug.LogWarning("Test");
        foreach (var dd in dp)
        {
            Debug.LogWarning(dd);
        }
        var d = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "at"));
        var ab = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "ui"));
        var prefab = ab.LoadAsset<GameObject>("Image");
        GameObject.Instantiate(prefab, transform);
        //prefab = ab.LoadAsset<GameObject>("Image2");
        //GameObject.Instantiate(prefab, transform);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
