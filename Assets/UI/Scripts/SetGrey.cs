using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class SetGrey : MonoBehaviour {

    public Material GreyMaterial;
    public bool Grey = false;

    private Image mImage;
    private Material mDefaultMaterial;

	void Start () {
        mImage = GetComponent<Image>();
        mDefaultMaterial = mImage.material;
        UpdateGrey();
    }
	

    private void OnValidate()
    {
        UpdateGrey();
    }

    private void UpdateGrey()
    {
        if (mImage != null)
        {
            mImage.material = Grey ? GreyMaterial : mDefaultMaterial;
        }
    }
}
