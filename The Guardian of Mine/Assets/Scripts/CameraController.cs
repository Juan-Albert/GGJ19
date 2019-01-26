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

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1.5f, layerMask))
        {
            Debug.Log("Hit");
            //hit.collider.GetComponent<BorderController>().changeColor = true;
            lastGameObject = hit.collider.gameObject;
            detectLastObject = true;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("click");
            }

        }
        else if (detectLastObject == true)
        {
            Debug.Log("No Hit");
            detectLastObject = false;
            //if (lastGameObject != null) lastGameObject.GetComponent<BorderController>().changeColor = false;
        }
    }

}
