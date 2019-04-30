using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{

    public bool itemObtained;



    // Update is called once per frame
    void Update()
    {
        if (itemObtained && gameObject.name == "Chest" || gameObject.name == "Chest_CubiertaSuperior")
        {
            GetComponent<GetFinalItem>().openChest = true;
            return;
        }
        else if (itemObtained)
            this.gameObject.SetActive(false);

    }

    



}
