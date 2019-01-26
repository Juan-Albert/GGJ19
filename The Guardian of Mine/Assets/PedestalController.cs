using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PedestalController : MonoBehaviour
{
    public GameObject[] obj;
    public GameObject book;

    public GameObject firstPersonController;

    public Material illuminated;
    public Material dissolution;
    public Material illuminationBorder;

    private bool inTrigger = false;
    private bool giveMeBook = false;
    private bool inChange = false;
    private bool dissolve_obj = false;

    public float changeTime = 5f;
    public float time_ratio = 1f;
    private float not_dis = 0.5f;
    private float dis = -0.5f;

    // Start is called before the first frame update
    void Start()
    {
        illuminated.SetFloat("_width", 1f);
        dissolution.SetFloat("_dissolve",0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (dissolve_obj)
        {
            not_dis -= Time.deltaTime / time_ratio;
            if (not_dis <= dis)
            {
                not_dis = -0.5f;
                obj[0].SetActive(false);
                obj[1].SetActive(false);
                obj[2].SetActive(false);
                book.SetActive(true);
                GetBook();
            }
                
            dissolution.SetFloat("_dissolve", not_dis);
        }
        else if (giveMeBook)
        {
            dis += Time.deltaTime / time_ratio;
            if (dis >= 0.5f)
            {
                dis = 0.5f;
                ReturnControl();
                giveMeBook = false;
                float[] values = new float[2];
                values[0] = 1f;
                values[1] = 1f;
                illuminationBorder.SetFloatArray("_Thickness", values);
                book.GetComponent<MeshRenderer>().material = illuminationBorder;
            }

            dissolution.SetFloat("_dissolve", dis);
        }
        else
        {
            if (inTrigger && Input.GetMouseButtonDown(1) && !dissolve_obj)
            {
                ChangeMaterial();
                dissolve_obj = true;
                DissolveObj();
            }
            else if (inTrigger && Input.GetMouseButtonDown(1) && book.activeInHierarchy)
            {
                book.SetActive(false);
            }
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (book.activeInHierarchy)
            {
                float[] values = new float[2];
                values[0] = 0.85f;
                values[1] = 0.85f;
                illuminationBorder.SetFloatArray("_Thickness", values);
            }


            illuminated.SetFloat("_width", 0.1f);
            inTrigger = true;
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (book.activeInHierarchy)
            {
                float[] values = new float[2];
                values[0] = 0.85f;
                values[1] = 0.85f;
                illuminationBorder.SetFloatArray("_Thickness", values);
            }

            illuminated.SetFloat("_width", 1f);
            inTrigger = false;
        }
    }

    void DissolveObj()
    {
        firstPersonController.GetComponent<FirstPersonController>().enabled = false;
    }

    void ReturnControl()
    {
        firstPersonController.GetComponent<FirstPersonController>().enabled = true;
    }

    void GetBook()
    {
        giveMeBook = true;
        dissolve_obj = false;
    }

    void ChangeMaterial()
    {
        foreach(GameObject g in obj)
        {
            g.GetComponent<MeshRenderer>().material = dissolution;
        }
        
    }
}
