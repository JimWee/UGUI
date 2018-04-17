using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGrey : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var renderer = GetComponent<Renderer>();
        var prop = new MaterialPropertyBlock();
        prop.SetFloat("_Grey", 1);
        renderer.SetPropertyBlock(prop);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
