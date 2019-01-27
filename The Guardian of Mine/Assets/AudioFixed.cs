using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFixed : MonoBehaviour
{
    public AudioSource audio;

    // Update is called once per frame
    void Update()
    {
        audio.pitch = Random.Range(1f, 1.2f);
    }
}
