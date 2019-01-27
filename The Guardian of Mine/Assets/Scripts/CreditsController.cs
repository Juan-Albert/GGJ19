using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Start");
    }

    public void RestartToMainScene()
    {
        SceneManager.LoadScene("Menu");
    }

}
