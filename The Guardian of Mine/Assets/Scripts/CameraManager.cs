using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraManager : MonoBehaviour
{
    public Animator myTransicion;
    public float time, transitionTime;
    private float finalTime, finalTransTime;

    public Camera mainCamera;

    public List<Camera> cameras;

    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        finalTime = time;
        mainCamera = cameras[i];
    }

    // Update is called once per frame
    void Update()
    {
        finalTime -= Time.deltaTime;
        //finalTransTime -= Time.deltaTime;

        //if (finalTransTime <= 0)
        //{
        //    StartCoroutine(myLoadFade());

        //    finalTransTime = transitionTime;

        //}

        
        if (finalTime <= 0)
        {
            i++;
            
            if (i == 3)
            {
                i = 0;
            }
            mainCamera = cameras[i];
            finalTime = time;
        }

        
        if (i==0)
        {
            cameras[0].gameObject.SetActive(true);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(false);
        }
        else if (i == 1)
        {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(true);
            cameras[2].gameObject.SetActive(false);
        }
        else if (i == 2)
        {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(true);
        }
    }


        
    

    //IEnumerator myLoadFade()
    //{
       
    //    myTransicion.SetTrigger("end");
    //    yield return new WaitForSeconds(10f);
        
    //}
}
