using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

    public static int moveValue=4;
    public Text move;

    public Move(Text move)
    {
        this.move = move;
    }

    // Use this for initialization
    void Start()
    {
        move = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveValue <= 0)
        {
            moveValue = 0;
        }
        move.text = moveValue.ToString();
    }


}
