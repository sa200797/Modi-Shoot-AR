using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Found_Lost : MonoBehaviour
{
    public GameObject TextPannel;

    public void TrackFound()
    {

        Time.timeScale = 1f;
        TextPannel.SetActive(false);
    }

    public void TracklLost()
    {
        Time.timeScale = 0f;
        TextPannel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
