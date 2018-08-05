using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {
    public void PlayButton()
    {
        //Application.LoadLevel("GamePlay");
        //Time.timeScale = 1f;
        SceneManager.LoadScene("GamePlay");
    }
}
