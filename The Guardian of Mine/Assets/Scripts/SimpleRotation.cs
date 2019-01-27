using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SimpleRotation : MonoBehaviour
{
    private Rigidbody myRB;
    private Vector3 m_EulerAngleVelocity;

    private void Start()
    {
        m_EulerAngleVelocity = new Vector3(0, 0, 50);
        myRB = this.gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
        myRB.MoveRotation(myRB.rotation * deltaRotation);
    }
}
