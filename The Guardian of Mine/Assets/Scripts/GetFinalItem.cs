using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFinalItem : MonoBehaviour
{

    public GameObject go1, go2;
    public GameObject door;

    public bool fIO, sIO, missionCompleted;


    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(fIO == true && sIO == true)
        {
            missionCompleted = true;
            anim.SetBool("Activated", true);
            door.GetComponent<DoorKnob>().levelEnded = true;


        }
        else
        CheckStatus();

    }

    public void CheckStatus()
    {
        if (!missionCompleted)
        {
            fIO = go1.GetComponent<GetItem>().itemObtained;
            sIO = go2.GetComponent<GetItem>().itemObtained;
        }

    }

}
