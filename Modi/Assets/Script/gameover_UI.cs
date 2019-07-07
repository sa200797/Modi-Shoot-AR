﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover_UI : MonoBehaviour
{
    public PlayerHealth playerHealth;

   
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            // ... tell the animator the game is over
            anim.SetTrigger("GameOver");
        }

        
    }
}
