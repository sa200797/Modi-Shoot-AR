using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading_Bar : MonoBehaviour
{
   

    public void Awake()
    {
       
    }

    public void Start()
    {
        
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 9.0f);

           

            Debug.Log(operation.isDone);
            yield return null;

        }
    }

    public void Update()
    {

    }


}

