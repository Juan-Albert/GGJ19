using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObject : MonoBehaviour
{
    public GameObject originalMesh;
    public GameObject sphereMesh;

    public PlanetControlller planetController;

    private Animator anim;

    private bool inTrigger;

    void Start()
    {
        anim = GetComponent<Animator>();
        sphereMesh.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1) && inTrigger)
        {
            anim.SetTrigger("TransformToSphere");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            inTrigger = false;
        }
    }

    public void FinalAnimation()
    {
        this.gameObject.SetActive(false);
    }

    public void ChangeForm()
    {
        originalMesh.SetActive(false);
        sphereMesh.transform.position = originalMesh.transform.position;
        sphereMesh.SetActive(true);
    }
}
