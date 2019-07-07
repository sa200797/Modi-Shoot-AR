using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastClickSound : MonoBehaviour
{

    private AudioSource audioSource;
   
    public GameObject player;

    public AudioSource allAudioSources;

    public Image Imagetouch;

    public DualJoystickPlayerController DualJoystickPlayerController;

    void Awake()
    {
        player= GameObject.FindGameObjectWithTag("Player");
       DualJoystickPlayerController = player.GetComponent<DualJoystickPlayerController>();
        allAudioSources = player.GetComponent<AudioSource>();

       

        audioSource = GetComponent<AudioSource>();
       
    }

    public void StopAllAudio()
    {
        if (allAudioSources.isPlaying)
        {


            audioSource.Stop();
            
            Debug.Log("Player Audio Source");
        }


    }

    public void PlayMyAudio()
    {
        

        /*if(player.transform.position.x > 0.0f && player.transform.position.z > 0.0f)
        {
            audioSource.Play();
            Debug.Log("Main menu 1");
            
        }
        if(player.transform.position.x < 0.0f && player.transform.position.z < 0.0f)
        {
            audioSource.Play();
            Debug.Log("Main menu 2");

        }
        */

        if(DualJoystickPlayerController.leftJoystickInput.x > 0 && DualJoystickPlayerController.leftJoystickInput.z > 0)
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }


            
           
            allAudioSources.Stop();
        }

        if (DualJoystickPlayerController.leftJoystickInput.x < 0 && DualJoystickPlayerController.leftJoystickInput.z < 0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            allAudioSources.Stop();
            
        }

       
    }
        
        
               
    
           
        
       
  
    public void Update()
    {
        StopAllAudio();

        PlayMyAudio();
       
    }

}