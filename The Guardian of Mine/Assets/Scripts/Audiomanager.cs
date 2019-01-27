using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
