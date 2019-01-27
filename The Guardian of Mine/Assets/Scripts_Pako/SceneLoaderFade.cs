using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderFade : MonoBehaviour
{
    public Animator myTransicion;
    public string sceneName;

    public void SceneLoader() {

        StartCoroutine(myLoadScene());
    }

    IEnumerator myLoadScene()
    {

        myTransicion.SetTrigger("end");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(sceneName);
    }

}
