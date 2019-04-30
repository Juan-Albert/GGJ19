using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFinalItem : MonoBehaviour
{

    public GameObject go1, go2;
    public GameObject door;

    public GameObject sphereStar;
    
    public bool fIO, sIO, openChest, missionCompleted;


    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
        fIO = sIO = openChest = missionCompleted = false;
        anim = GetComponent<Animator>();
        sphereStar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(fIO == true && sIO == true && openChest == true)
        {
            missionCompleted = true;
            door.GetComponent<DoorKnob>().levelEnded = true;
            anim.SetBool("Open", true);
        }
        else if (fIO == true && sIO == true && openChest == false)
        {
            // Preparar la el rayCast para el cofre
            anim.SetBool("Activated", true);
            if (GetComponent<GetItem>() == null)
                this.gameObject.AddComponent<GetItem>();
            
        }
        else
            CheckStatus();

    }

    public void CheckStatus()
    {
        if (!missionCompleted || !openChest)
        {
            fIO = go1.GetComponent<GetItem>().itemObtained;
            sIO = go2.GetComponent<GetItem>().itemObtained;
        }
        else if (GetComponent<GetItem>() != null)
            openChest = GetComponent<GetItem>().itemObtained; 

    }

    public void initStar()
    {
        sphereStar.SetActive(true);
        sphereStar.GetComponent<Animator>().SetBool("Init", true);
    }

}
