using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    public GameObject bridge;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Holi");

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Holi");
            if (Input.GetMouseButtonDown(1))
            {
                bridge.GetComponent<Animator>().SetBool("Active", true);
            }
                
        }
    }
}
