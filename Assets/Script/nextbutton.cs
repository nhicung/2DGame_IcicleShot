using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextbutton : MonoBehaviour
{

    public void PlayButton()
    {
        //Application.LoadLevel("GamePlay");
        SceneManager.LoadScene("levelscreen");

    }
}
