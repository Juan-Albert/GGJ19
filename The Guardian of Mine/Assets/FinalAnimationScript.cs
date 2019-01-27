using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAnimationScript : MonoBehaviour
{
    private Animator anim;
    public float time = 5f;
    public GameObject canvas;
    private AudioSource audioSource;

    public AudioClip goodNight;
    public AudioClip song;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        Invoke("Sleep", time);
    }

    void Say()
    {
        audioSource.PlayOneShot(goodNight);
    }

    void Sleep()
    {
        anim.SetTrigger("GoodNight");
    }
 
    public void Final()
    {
        //Poner Aqui el final y activar los creditos
        canvas.SetActive(true);
        //audioSource.PlayOneShot(audioSource.clip);
        anim.Play("Empty");
        
        audioSource.PlayOneShot(song);
    }
}
