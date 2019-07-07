using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    /* Timer
     * Enemy Destoryes  and my time decreases
     * spawn rate of enemies inceases and random enemies increases;
            in few seconds
     */
     
     /*
      * 0-33
      * 33-66
      * 66-99
      */

/*
    [SerializeField] Slider corruption;
    [SerializeField] Slider demonitization;
    [SerializeField] Slider terriost;


    [SerializeField]  float maxtime;

    public float timer;

    public bool timerisActive = true;


    PlayerHealth playerHealth;
    public GameObject player;

    public Add_Manager add_Manager;

    private void Awake() 
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        add_Manager =GetComponent<Add_Manager>();

       
    }



    // Start is called before the first frame update
    void Start()
    {
        
        corruption.maxValue = maxtime;
        demonitization.maxValue = maxtime;
        terriost.maxValue = maxtime;

      


    }

    // Update is called once per frame
    public void Update()
    {
        if (timerisActive)
        {
            timer += Time.deltaTime;

            corruption.value = timer;
            demonitization.value = timer;
            terriost.value = timer;

            if (timer >= maxtime)
            {
                timer = maxtime;
                timerisActive = false;
               // playerHealth.Death();
            }
        }

        
    }
    */
    

    
}



