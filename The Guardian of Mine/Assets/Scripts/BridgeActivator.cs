using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeActivator : MonoBehaviour
{



    public bool itemObtained;

    public Material mat1, mat2;

    public GameObject bridge;

    private void Start()
    {
        this.GetComponent<Renderer>().material = mat1;
    }


    // Update is called once per frame
    void Update()
    {

        if (itemObtained)
        {
            this.GetComponent<Renderer>().material = mat2;
            bridge.GetComponent<Animator>().SetBool("Active", true);
        }

        else
        {
            this.GetComponent<Renderer>().material = mat1;
        }
    }





}
