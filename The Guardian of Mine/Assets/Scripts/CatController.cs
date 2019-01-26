using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{

    public GameObject player;

    public GameObject parent;

    

    // Update is called once per frame
    void Update()
    {


        Vector3 targetVector = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);

        transform.LookAt(targetVector);

        //float diference = parent.transform.eulerAngles.y - transform.eulerAngles.y;
        //print(diference);
        //if (diference >= 90 && diference <= 180)
        //    transform.eulerAngles = new Vector3(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
        //else if(diference > -180 && diference >= -90)
        //    transform.eulerAngles = new Vector3(transform.eulerAngles.x, -90f, transform.eulerAngles.z);



        if (transform.eulerAngles.y >= 90 && transform.eulerAngles.y <= 180)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
        }
        else if (transform.eulerAngles.y >= 180 && transform.eulerAngles.y <= 270)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, -90f, transform.eulerAngles.z);
        }
    }
}
