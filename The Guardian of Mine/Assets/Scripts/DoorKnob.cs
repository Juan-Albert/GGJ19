using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnob : MonoBehaviour
{
    public GameObject door;
    public GameObject collider;
    public bool levelEnded = false;

    public void Activate()
    {
        door.GetComponent<Animator>().SetTrigger("Activate");
        collider.SetActive(true);
    }
}
