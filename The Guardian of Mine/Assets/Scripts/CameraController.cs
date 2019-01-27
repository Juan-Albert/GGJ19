using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    public LayerMask layerMask;

    private bool detectLastObject = false;
    private GameObject lastGameObject;

    private RaycastHit hit;



    void Update()
    {
        detectThings();
        
    }

    private void detectThings()
    {
        Debug.Log("Holi");
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1.5f, layerMask))
        {
            Debug.Log("Hit");
            hit.collider.GetComponent<BorderController>().changeColor = true;
            lastGameObject = hit.collider.gameObject;
            detectLastObject = true;
            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("click");
                Debug.Log(hit.collider.gameObject.name);
                if(hit.collider.gameObject.CompareTag("Lever"))
                {
                    Debug.Log("Lever");
                    hit.collider.gameObject.GetComponent<Animator>().SetBool("Activate", true);
                    hit.collider.gameObject.GetComponent<LeverController>().Activate();
                }
                else if (hit.collider.gameObject.CompareTag("knob"))
                {
                    Debug.Log("knob");
                    hit.collider.gameObject.GetComponent<DoorKnob>().Activate();
                }
                else if (hit.collider.gameObject.CompareTag("itemPirates"))
                {
                    Debug.Log("knob");
                    hit.collider.gameObject.GetComponent<GetItem>().itemObtained = true;
                }

            }

        }
        else if (detectLastObject == true)
        {
            Debug.Log("No Hit");
            detectLastObject = false;
            if (lastGameObject != null) lastGameObject.GetComponent<BorderController>().changeColor = false;
        }
    }

}
