using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderController : MonoBehaviour
{
    public bool changeColor = false;
    public bool highlightNow = true;

    [ColorUsageAttribute(true, true)]
    public Color edgeColor;


    void Update()
    {
        if (changeColor && highlightNow)
        {
            GetComponent<Renderer>().material.SetFloat("_width", 0.1f);

        }
        else
        {
            GetComponent<Renderer>().material.SetFloat("_width", 1f);

        }
    }
}
