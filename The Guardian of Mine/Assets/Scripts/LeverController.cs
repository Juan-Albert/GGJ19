using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{

    AudioSource aS;

    public GameObject bridge;

    private void Start()
    {
        aS = GetComponent<AudioSource>();
    }

    public void Activate()
    {
        bridge.GetComponent<Animator>().SetBool("Active", true);
        aS.Play();
    }
}
