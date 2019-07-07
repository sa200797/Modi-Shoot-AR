using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindModi : MonoBehaviour
{
    public Transform player;
    public GameObject modi;

    public void PlayerPos()
    {
         modi.transform.position = player.transform.position;
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
