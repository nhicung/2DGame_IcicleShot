using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    public static int goalValue = 100;
    public Text goal;

    public Goal(Text goal)
    {
        this.goal = goal;
    }

    // Use this for initialization
    void Start()
    {
        goal = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        goal.text = "Goal: " + goalValue;
    }


}
