using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    public GameObject bridge;

    public void Activate()
    {
        bridge.GetComponent<Animator>().SetBool("Active", true);
    }
}
