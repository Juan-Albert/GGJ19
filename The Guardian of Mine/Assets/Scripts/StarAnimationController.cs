using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine;

public class StarAnimationController : MonoBehaviour
{
    private Animator starAnimatorController;

    public GameObject estela;

    public Vector3 startPosition;
    public Vector3 startRotation;

    public PedestalController pc;
    private RigidbodyFirstPersonController fpc;
    

    // Start is called before the first frame update
    void Start()
    {
        starAnimatorController = GetComponentInChildren<Animator>();
        fpc = GetComponent<RigidbodyFirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.bookTaked)
        {
            pc.bookTaked = false;
            //Invoke("LookStar",0.5f);
        }
    }
    
    void LookStar()
    {
        //transform.position = new Vector3(startPosition.x, transform.position.y, startPosition.z);
        //transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        //camera.transform.Rotate(startRotation.x, startRotation.y, startRotation.z);
        fpc.enabled = false;
    }
}
