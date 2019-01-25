using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float sensitivityY = 15F;
    public float minimumY = -60F;
    public float maximumY = 60F;

    float rotationY = 0F;

    public bool movement;

    void Update()
    {
        if (movement)
        {

            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
        }
    }
}
