using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI_Manager : MonoBehaviour
{
    public GameObject gameover;



    public Button_Active button_active1;
    public Button_Active button_active2;
    public Button_Active button_active3;


    [SerializeField] GameObject[] ObjCorruption;
    [SerializeField] GameObject[] ObjDemo;
    [SerializeField] GameObject[] ObjTerr;


    [SerializeField] GameObject deathparticles1;
    [SerializeField] GameObject deathparticles2;
    [SerializeField] GameObject deathparticles3;

   // public GameObject gamemanager;

    public AudioSource audiosource;
    public AudioClip[] audioClips;

    public Add_Manager add_Manager;

    //public Add_Manager add_Manager;

    private void Awake()
    {
        gameover.SetActive(false);

      //  gamemanager = GameObject.Find("GameManager");

        audiosource = GetComponent<AudioSource>();

        add_Manager = GetComponent<Add_Manager>();
       

    }


    public void Game_Retry()
    {
      
        SceneManager.LoadScene(1);
      
    }

    public void Game_Menu()
    {
        //add_Manager.ShowVideoAdd();
        SceneManager.LoadScene(0);
        add_Manager.ShowVideoAdd();
    }

   

    public void Corruption()
    {

        //  enemyHealth1.Death();


        foreach (GameObject go in ObjCorruption)
        Destroy(go,0.3f);

        
        
     
         ScoreManager.score += 2;
         GameObject po = Instantiate(deathparticles1) as GameObject;

          foreach (GameObject go1 in ObjCorruption)
          po.transform.position = go1.transform.position;

        button_active1.ResetTimer();
       // gamemanager.GetComponent<GameManager>().timer -= 5.0f;

        audiosource.clip = audioClips[0];
        audiosource.PlayOneShot(audioClips[0]);


    }

    public void Demo()
    {
        foreach (GameObject demon in ObjDemo)
            Destroy(demon);

        ScoreManager.score += 3;
        GameObject po = Instantiate(deathparticles2) as GameObject;

        foreach (GameObject demon2 in ObjDemo)
            po.transform.position = demon2.transform.position;

      //  gamemanager.GetComponent<GameManager>().timer -= 5.0f;

        button_active2.ResetTimer();

        audiosource.clip = audioClips[0];
        audiosource.PlayOneShot(audioClips[0]);
    }

    public void Terr()
    {
        foreach (GameObject terr in ObjTerr)
            Destroy(terr);

        ScoreManager.score += 4;
        GameObject po = Instantiate(deathparticles3) as GameObject;
       

            foreach (GameObject terr2 in ObjTerr)
            po.transform.position = terr2.transform.position;
        button_active3.ResetTimer();

        audiosource.clip = audioClips[1];
        audiosource.PlayOneShot(audioClips[1]);

      //  gamemanager.GetComponent<GameManager>().timer -= 5.0f;

    }
     
  



    // Start is called before the first frame update
    void Start()
    {
        add_Manager.ShowVideoAdd();
    }

    // Update is called once per frame
    void Update()
    {
        ObjCorruption = GameObject.FindGameObjectsWithTag("Enemy");        
            ObjDemo = GameObject.FindGameObjectsWithTag("Enemy2");
        ObjTerr = GameObject.FindGameObjectsWithTag("Enemy3");


       

    }
}
