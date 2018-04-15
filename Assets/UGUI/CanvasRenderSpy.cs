using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CanvasRenderSpy : MonoBehaviour {

    public int absoluteDepth = -1;
    public int relativeDepth = -1;
    public CanvasRenderer canvasRender;
    
	// Use this for initialization
	void Start () {
        Sprite s;
	}

    private void OnEnable()
    {
        if (canvasRender == null)
        {
            canvasRender = GetComponent<CanvasRenderer>();
        }
        if (canvasRender != null)
        {
            absoluteDepth = canvasRender.absoluteDepth;
            relativeDepth = canvasRender.relativeDepth;
        }
    }
}
