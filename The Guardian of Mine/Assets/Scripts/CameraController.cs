using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float sensitivityY = 15F;
    public float minimumY = -60F;
    public float maximumY = 60F;

    float rotationY = 0F;

    public bool movement;

    public Material border;

    void Update()
    {
        if (movement)
        {

            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
        }



        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 9;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1.5f, layerMask))
        {

            hit.collider.GetComponent<Renderer>().material = border;

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
            if (Input.GetMouseButtonDown(0))
                hit.collider.GetComponent<GetItem>().itemObtained = true;

        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }

}
