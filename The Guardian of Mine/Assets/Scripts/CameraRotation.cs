using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    public GameObject terrain;

    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(this.transform.position, terrain.transform.position);

        Debug.Log(distance);

        transform.RotateAround(terrain.transform.position, new Vector3(0,1,0), 20 * Time.deltaTime * speed);


    }
}
