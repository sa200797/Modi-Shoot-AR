using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DanceScript : MonoBehaviour
{


    public GameObject gamesheet;

    public Add_Manager add_Manager;

    public void GameStart()
    {
        add_Manager.CLOSEbANNER();
        SceneManager.LoadScene(2);
        
    }

    public void InstructionSheet()
    {
       
        gamesheet.SetActive(true);
        
    }

    public void GameExit()
    {
       
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        gamesheet.SetActive(false);
        add_Manager.ShowBannerAdd();

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
