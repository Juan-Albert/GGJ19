using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeMaterial : MonoBehaviour
{

    public float currentExposure = 0.5f;
    public Material targetMaterial;
	
	void Update ()
    {
        targetMaterial.SetFloat("Vector1_A1674467", currentExposure);

    }
}
