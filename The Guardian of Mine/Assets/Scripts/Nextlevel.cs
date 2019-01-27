using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextlevel : MonoBehaviour
{
    public GameObject door;

    public GameObject falseDoor;
    public Material shader;

    private float dis = -0.5f;

    private bool dissolve = false;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Goto");
    }

    void Update()
    {
        if (dissolve == true)
        {
            dis += Time.deltaTime;
            print(dis);
            if (dis >= 0.5f)
            {
                dis = 0.5f;
                door.SetActive(true);
                falseDoor.SetActive(false);
            }

            shader.SetFloat("_dissolve", dis);
        }
    }

    public void GetDoor() {
        //door.SetActive(true);
        falseDoor.SetActive(true);
        //this.gameObject.SetActive(false);
        dissolve = true;
        shader.SetFloat("_dissolve", -0.5f);
        print("shader");
    }
}
