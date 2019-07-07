using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject TextPannel;

    public GameObject EnemyBar;

   
    

    public void Awake()
    {
        TextPannel.SetActive(false);
        EnemyBar.SetActive(false);
        
    }

    public void TrackFound()
    {

        Time.timeScale = 1f;
        TextPannel.SetActive(false);
        EnemyBar.SetActive(true); 
        
    }

    public void TrackLost()
    {
        Time.timeScale = 0f;
        TextPannel.SetActive(true);
        EnemyBar.SetActive(false);
       
    }
}
