using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFinalItem : MonoBehaviour
{

    public GameObject go1, go2;

    public bool fIO, sIO;

    public Material mat;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(fIO == true && sIO == true)
        {
            Debug.Log("A TOPE");
            anim.SetBool("Activated", true);
            this.GetComponent<Renderer>().material = mat;
            
        }
        else
        CheckStatus();

    }

    public void CheckStatus()
    {
        fIO = go1.GetComponent<GetItem>().itemObtained;
        sIO = go2.GetComponent<GetItem>().itemObtained;
    }

}
