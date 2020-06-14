using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject instructBoard;
    public Text instructText;
    int counter;
   // public bool instructActive;

    void Start()
    {
        instructBoard.SetActive(false);
        //Time.timeScale = 1f;
    }

    void Update()
    {
       // if (instructActive)
       // {
          // instructBoard.SetActive(false);
            //instructActive = false;
            // Time.timeScale = 1f;
       // }
    }

    public void ShowHideBoard()
    {
        //instructActive = true;
        counter++;
        if (counter % 2 == 1)
        {
            instructBoard.SetActive(true);
        }
        else
        {
            instructBoard.SetActive(false);
        }
    }
}
