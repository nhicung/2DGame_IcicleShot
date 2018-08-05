using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject instructBoard;
    public Text instructText;
    int counter;

    void Start()
    {
        instructBoard.SetActive(false);
    }

    void Update()
    {
      
    }

    public void ShowHideBoard()
    {
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
