using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFinalItem : MonoBehaviour
{

    public GameObject go1, go2;

    public bool fIO, sIO;

    public Material mat;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(fIO && sIO)
            this.GetComponent<Renderer>().material = mat;

        CheckStatus();

    }

    public void CheckStatus()
    {
        fIO = go1.GetComponent<GetItem>().itemObtained;
        sIO = go2.GetComponent<GetItem>().itemObtained;
    }

}
