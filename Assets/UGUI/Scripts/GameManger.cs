using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

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
        var image = GameObject.Instantiate<GameObject>(prefab, transform);
        image = GameObject.Instantiate<GameObject>(prefab, transform);
        image.transform.localPosition = new Vector3(100f, 0f, 0f);
        var s = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "res"));
        var usa = s.LoadAsset<UISpriteAtlas>("Bn");
        image.GetComponent<Image>().sprite = usa.GetSprite("UI_UP");
        //prefab = ab.LoadAsset<GameObject>("Image2");
        //GameObject.Instantiate(prefab, transform);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
