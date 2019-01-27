using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWritterEffect : MonoBehaviour
{
    public float delay = 0.1f;
    private string fullText = "It is said that home is a quiet and cozy place, where we feel safe, where we find happiness and relief, and otherwise, tears and anger. ";
    private string fullText2 = "Besides, everyone that means something to us and that marks us during our lives, that, that is also home. ";


    private string currentText = "";

    public int contador = 1;

    public float timeLeft;

    // Use this for initialization
    void Start()
    {
        //Events

        //Event1
        if(contador == 1)
        {
            StartCoroutine(ShowText());
            
        }


        else if(contador == 2)
            StartCoroutine(ShowText1());

    }

    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(5f);

        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator ShowText1()
    {


        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);

        }
    }



}
