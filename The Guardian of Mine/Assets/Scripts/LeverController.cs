using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{

    AudioSource aS;

    public GameObject bridge;

    public DoorKnob doorKnob;

    private void Start()
    {
        aS = GetComponent<AudioSource>();
    }

    public void Activate()
    {
        doorKnob.levelEnded = true;
        bridge.GetComponent<Animator>().SetBool("Active", true);
        aS.Play();
    }
}
