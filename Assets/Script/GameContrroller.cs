using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    //public AudioClip Winning;
    public Text LevelComplete;
    public Text LevelLose;
    public Text goal;
    public Text score;

    // Use this for initialization

    public void CheckIfGameWon()
    {
        if (Score.scoreValue == Goal.goalValue)
        {
            WinGame();
        }
        else if (Score.scoreValue < Goal.goalValue && Move.moveValue == 0)
        {
            LoseGame();
        }
    }
    public void WinGame()
    {
        LevelComplete.text = "Win!";
    }
    public void LoseGame()
    {
        LevelLose.text = "Lose";
    }

}