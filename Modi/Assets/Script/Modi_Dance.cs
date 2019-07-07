using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modi_Dance : MonoBehaviour
{
     Animator anim;

    public AudioClip[] sound;
    public AudioSource audioSource;

    public void Awake()
    {
        anim = GetComponentInChildren<Animator>();

        audioSource = GetComponent<AudioSource>();

       

    }

    public void Dance1()
    {
        anim.SetBool("Dance1",true);
        // anim.Play("Dancing");
        audioSource.clip = sound[0];
        
        audioSource.Play();
        
    }

    public void Dance2()
    {
        anim.SetBool("Dance2", true);
        
        audioSource.clip = sound[1];
        
        audioSource.Play();
      
    }

    public void Dance3()
    {
        
        anim.SetTrigger("Dance3");
        audioSource.clip = sound[2];
        
        audioSource.Play();
      
    }

    public void Dance4()
    {
        
        anim.SetBool("Dance4", true);
        audioSource.clip = sound[3];
        audioSource.Play();
        
    }

    public void Movement()
    {
        audioSource.clip = sound[4];
        audioSource.Play();
    }

    
}
