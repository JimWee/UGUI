using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThreeDEventTest : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Color HighlightedColor = Color.red;
    public Color NormalColor = Color.white;
    public Color PressedColor = Color.green;

    private Material m;

    void Start () {
        var renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            m = renderer.material;
            m.color = NormalColor;
        }
	}
	
	void Update () {
		
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(m != null)
        {
            m.color = HighlightedColor;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (m != null)
        {
            m.color = NormalColor;
        }
    }
}
