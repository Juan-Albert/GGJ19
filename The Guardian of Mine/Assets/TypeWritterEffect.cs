using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWritterEffect : MonoBehaviour
{
    public float delay = 0.1f;
    private string fullText = "It is said that home is a quiet and cozy place, where we feel safe, where we find happiness and relief, and otherwise, tears and anger. ";
    private string fullText2 = "Besides, everyone that means something to us and that marks us during our lives, that, that is also home. ";
    private string fullText3 = "But, home, it is not just what we feel or see, it’s something else, it’s our stories and ambitions, our dreams, our likes and of course, our imagination. ";
    private string fullText4 = "And there is it, in the most innocence imagination, that which creates the best stories, that which endures along the time. ";
    private string currentText = "";

    public int contador = 1;

    public float waitTime;

    public AudioSource aS1, aS2, aS3, aS4;

    LoadScene sceneLoader;

    // Use this for initialization
    void Start()
    {
        //Events

        //Event1
        if(contador == 1)
        {
            StartCoroutine(ShowText());
            
        }

    }

    IEnumerator ShowText()
    {

        aS1.Play();
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }

        yield return new WaitForSeconds(waitTime);
        aS2.Play();
        for (int i = 0; i < fullText2.Length; i++)
        {
            currentText = fullText2.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);

        }

        yield return new WaitForSeconds(waitTime);
        aS3.Play();
        for (int i = 0; i < fullText3.Length; i++)
        {
            currentText = fullText3.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);

        }

        yield return new WaitForSeconds(waitTime);
        aS4.Play();
        for (int i = 0; i < fullText4.Length; i++)
        {
            currentText = fullText4.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);

        }

        yield return new WaitForSeconds(3f);
        //sceneLoader.NextScene();

    }
    

}
