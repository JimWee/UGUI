﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameManger : MonoBehaviour {

    public Button button;

    // Use this for initialization
    void Start()
    {
        var m = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "AB"));
        AssetBundleManifest am = m.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        var dp = am.GetAllDependencies("prefabs");
        Debug.LogWarning("Test");
        foreach (var dd in dp)
        {
            Debug.LogWarning(dd);
        }
        var d = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "sprite atlas"));
        var ab = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "prefabs"));
        var prefab = ab.LoadAsset<GameObject>("UGUI Sprite Atlas");
        var image = GameObject.Instantiate<GameObject>(prefab, transform);
        //image = GameObject.Instantiate<GameObject>(prefab, transform);
        //image.transform.localPosition = new Vector3(100f, 0f, 0f);
        //var s = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "res"));
        //var usa = s.LoadAsset<UISpriteAtlas>("Bn");
        //image.GetComponent<Image>().sprite = usa.GetSprite("UI_UP");
        //prefab = ab.LoadAsset<GameObject>("Image2");
        //GameObject.Instantiate(prefab, transform);
    }

    //private void Start()
    //{
    //    button.onClick.AddListener(delegate ()
    //    {
    //        Debug.Log("AAAA");
    //    });
    //}

    // Update is called once per frame
    void Update () {
		
	}

    public void OnButtonClicked(string s)
    {
        Debug.Log("On Button Clicked" + s);
    }

}
