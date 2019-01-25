using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{

    public bool itemObtained;

    public Material mat1, mat2;

    private void Start()
    {
        mat1 = GetComponent<Material>();
    }


    // Update is called once per frame
    void Update()
    {

        if (itemObtained)
            mat1 = mat2;
            

    }

    

}
