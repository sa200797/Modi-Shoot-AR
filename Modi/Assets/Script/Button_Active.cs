using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button_Active : MonoBehaviour
{
    [SerializeField] Slider slider;

    public Button button;

    public float timeTowait;
    public  float currentWaitTime;
    bool checkTime;

    private void Awake()
    {

        slider.maxValue = timeTowait;
       

    }
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (checkTime)
        {
            currentWaitTime -= Time.deltaTime;

            slider.value += Time.deltaTime;

            if(currentWaitTime < 0)
            {
                TimerFinished();
                checkTime = false;
            }

        }
       
    }

    public void ResetTimer()
    {
        currentWaitTime = timeTowait;
        checkTime = true;
        button.interactable = false;
        slider.value = 0;
    }
    void TimerFinished()
    {
        button.interactable = true;
    }
}
