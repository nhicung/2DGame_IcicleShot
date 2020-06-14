using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scoreValue;
     Text score;

    public Score(Text score)
    {
        this.score = score;
    }
    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0; 
    }

    // Update is called once per frame
    void Update()
    {
            score.text = "Score: " + scoreValue;
        
    }
}
