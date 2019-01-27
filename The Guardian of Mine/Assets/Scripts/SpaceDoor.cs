using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDoor : MonoBehaviour
{

    public GameObject knob;

    public bool inside = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && inside)
        {
            Debug.Log("COlision");
            knob.GetComponent<DoorKnob>().Activate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            knob.GetComponent<BorderController>().changeColor = true;
            inside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            knob.GetComponent<BorderController>().changeColor = false;
            inside = false;
        }
    }
}
