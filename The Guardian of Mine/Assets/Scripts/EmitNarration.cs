using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitNarration : MonoBehaviour
{

    Collider area;

    AudioSource aS;

    private bool entered;

    Collider col;

    // Start is called before the first frame update
    void Start()
    {
        aS = GetComponent<AudioSource>();
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (entered)
            col.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            aS.Play();
            entered = true;
        }
    }

}
