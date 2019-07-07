using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    public Text ui_Score;
    public Text GameUi_score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Score" + " " + score);
        ui_Score.text = ((int)score).ToString();
        GameUi_score.text = ((int)score).ToString();
    }
}
