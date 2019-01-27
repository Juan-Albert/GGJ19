using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControlller : MonoBehaviour
{
    public bool objectsIn = false;

    public GameObject[] objects;
    public bool obj0 = false;
    public bool obj1 = false;
    public bool obj2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (obj0 && obj1 && obj2)
            objectsIn = true;

        if (objects[0].activeInHierarchy == false)
        {
            obj0 = true;
        }
        if (objects[1].activeInHierarchy == false)
        {
            obj1 = true;
        }
        if (objects[2].activeInHierarchy == false)
        {
            obj2 = true;
        }

    }
}
