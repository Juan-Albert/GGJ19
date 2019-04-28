using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squeez : MonoBehaviour
{
    public AudioSource squeez;
 


     void  OnMouseOver()
    {
       float myPitch = Random.Range(1f,1.1f);

        squeez.pitch = myPitch;

        if (Input.GetMouseButtonDown(0)){

            squeez.Play();
           
        }
    }


}
