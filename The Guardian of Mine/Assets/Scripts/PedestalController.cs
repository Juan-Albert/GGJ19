using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PedestalController : MonoBehaviour
{
    public PlanetControlller planetController;

    public GameObject[] obj;
    public GameObject[] sphereObj;
    public GameObject book;

    public GameObject firstPersonController;

    public Material sphereIllumination;
    public Material starIllumination;
    public Material houseIllumination;
    public Material heartIllumination;
    public Material illumination;
    public Material dissolution;
    public Material illuminationBorder;

    private bool inTrigger = false;
    private bool giveMeBook = false;
    private bool dissolve_obj = false;
    public bool bookTaked = false;

    public float changeTime = 5f;
    public float time_ratio = 1f;
    private float not_dis = 0.5f;
    private float dis = -0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        obj[0].GetComponent<MeshRenderer>().material = illumination;
        obj[1].GetComponent<MeshRenderer>().material = illumination;
        obj[2].GetComponent<MeshRenderer>().material = illumination;

        starIllumination.SetFloat("_width", 1f);
        houseIllumination.SetFloat("_width", 1f);
        heartIllumination.SetFloat("_width", 1f);

        illumination.SetColor("_Illumination", Color.gray);
        illumination.SetFloat("_alpha", 0.3f);
        dissolution.SetFloat("_dissolve",0.5f);
        illuminationBorder.SetVector("_Thickness", new Vector4(0.85f, 0.85f));
    }

    // Update is called once per frame
    void Update()
    {
        if (planetController.objectsIn)
        {

            if (dissolve_obj)
            {
                not_dis -= Time.deltaTime / time_ratio;
                if (not_dis <= dis)
                {
                    not_dis = -0.5f;
                    sphereObj[0].SetActive(false);
                    sphereObj[1].SetActive(false);
                    sphereObj[2].SetActive(false);
                    book.SetActive(true);
                    GetBook();
                    dissolve_obj = false;
                }

                dissolution.SetFloat("_dissolve", not_dis);
            }
            else if (giveMeBook)
            {
                Destroy(sphereObj[0]);
                Destroy(sphereObj[1]);
                Destroy(sphereObj[2]);

                dis += Time.deltaTime / time_ratio;
                if (dis >= 0.5f)
                {
                    dis = 0.5f;
                    giveMeBook = false;

                    illuminationBorder.SetVector("_Thickness", new Vector4(0.85f, 0.85f));
                    book.GetComponent<MeshRenderer>().material = illuminationBorder;
                    book.transform.Find("Cohete").gameObject.SetActive(true);
                    ReturnControl();
                }

                dissolution.SetFloat("_dissolve", dis);
            }
            else
            {
                if (inTrigger && Input.GetMouseButtonDown(1) && book.activeInHierarchy && !bookTaked)
                {
                    book.SetActive(false);
                    bookTaked = true;
                    DissolveObj();
                }
                else if (inTrigger && Input.GetMouseButtonDown(1) && !dissolve_obj && !bookTaked)
                {
                    ChangeMaterial();
                    dissolve_obj = true;
                    DissolveObj();
                }

            }
        }
    }

    private void FixedUpdate()
    {
        if (planetController.obj0 && !book.activeInHierarchy)
        {
            obj[0].SetActive(false);
            sphereObj[0].SetActive(true);
        }
        if (planetController.obj1 && !book.activeInHierarchy)
        {
            obj[1].SetActive(false);
            sphereObj[1].SetActive(true);
        }
        if (planetController.obj2 && !book.activeInHierarchy)
        {
            obj[2].SetActive(false);
            sphereObj[2].SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            
            if (book.activeInHierarchy)
            {
                illuminationBorder.SetVector("_Thickness", new Vector4(0.85f, 0.85f));
            }

            if (planetController.objectsIn)
            {
                starIllumination.SetFloat("_width", 0.1f);
                houseIllumination.SetFloat("_width", 0.1f);
                heartIllumination.SetFloat("_width", 0.1f);
            }
            else
            {
                illumination.SetColor("_Illumination", Color.red);
                illumination.SetFloat("_alpha", 1f);
            }
            
            inTrigger = true;
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            print(other.gameObject.name);
            if (book.activeInHierarchy)
            {
                illuminationBorder.SetVector("_Thickness", new Vector4(1f, 1f));
            }

            if (planetController.objectsIn)
            {
                starIllumination.SetFloat("_width", 1f);
                houseIllumination.SetFloat("_width", 1f);
                heartIllumination.SetFloat("_width", 1f);
            }
            illumination.SetColor("_Illumination", Color.gray);
            illumination.SetFloat("_alpha", 0.3f);
            inTrigger = false;
        }
    }

    void DissolveObj()
    {
        firstPersonController.GetComponent<RigidbodyFirstPersonController>().enabled = false;
    }

    void ReturnControl()
    {
        firstPersonController.GetComponent<RigidbodyFirstPersonController>().enabled = true;
    }

    void GetBook()
    {
        giveMeBook = true;
        sphereObj[0].SetActive(false);
        sphereObj[1].SetActive(false);
        sphereObj[2].SetActive(false);
        dissolve_obj = false;
    }

    void ChangeMaterial()
    {
        foreach(GameObject g in sphereObj)
        {
            g.GetComponent<MeshRenderer>().material = dissolution;
        }
        
    }
}
