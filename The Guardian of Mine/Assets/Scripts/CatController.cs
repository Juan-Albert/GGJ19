using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{

    public GameObject player;
    public Transform parent; 

    private bool canLook = false;
    

    // Update is called once per frame
    void Update()
    {

        Vector3 targetVector = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);

        if (parent.eulerAngles.y - transform.eulerAngles.x >= 70 && parent.eulerAngles.y - transform.eulerAngles.x <= 340)
        {
            canLook = false;
        }
        else
        {
            canLook = true;
        }

        if(canLook)
        {
            transform.LookAt(targetVector);
        }
    }
}
