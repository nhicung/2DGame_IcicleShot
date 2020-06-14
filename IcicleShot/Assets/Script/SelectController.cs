using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectController : MonoBehaviour
{

    public void PlayButton()
    {
        //Application.LoadLevel("GamePlay");
        SceneManager.LoadScene("Instruction");

    }
}
