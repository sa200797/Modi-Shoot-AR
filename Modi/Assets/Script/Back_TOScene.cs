using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Back_TOScene : MonoBehaviour
{
    public Add_Manager add_Manager;
    // Start is called before the first frame update
    void Awake()
    {
        add_Manager = GetComponent<Add_Manager>();
    }
    public void Goback()
    {
        add_Manager.ShowVideoAdd();
        SceneManager.LoadScene(0);
      
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
