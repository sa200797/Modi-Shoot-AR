using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class InstructionSheet : MonoBehaviour
{
    public GameObject[] gallery;
    //public GameObject displayImage;

    public int i = 0;

    public GameObject instrsheet;

    public void NextImg()
    {
        if(i +1  < gallery.Length )
        {
            i++;
            gallery[i].SetActive(true);
        }
    }


    public void BackImg()
    {
        if(i -1 >= 0)
        {
            gallery[i].SetActive(false);
            i--;
           
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ExitSheet()
    {
        instrsheet.SetActive(false);
            
    }
    // Update is called once per frame
    void Update()
    {
        //displayImage = gallery[i];
    }
}
