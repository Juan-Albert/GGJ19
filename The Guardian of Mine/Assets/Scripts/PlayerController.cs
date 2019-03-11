using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7f;
    public float jumpForce = 30f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        this.transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
        this.transform.Translate(Vector3.right * h * speed * Time.deltaTime);
    }
}
