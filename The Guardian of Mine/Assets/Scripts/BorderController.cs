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

            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).GetComponent<Renderer>().material.SetColor("_ColorSuperficial", edgeColor);
            }
        }
        else
        {
            GetComponent<Renderer>().material.SetFloat("_width", 1f);

            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).GetComponent<Renderer>().material.SetColor("_ColorSuperficial", Color.black);
            }
        }
    }
}
