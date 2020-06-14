using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelscreencontroller : MonoBehaviour
{
   
    void Start()
    {
  
    }
    public void PlayButton()
    {
            //Application.LoadLevel("GamePlay");
            //Time.timeScale = 1f;
            SceneManager.LoadScene("levelselect");
        
    }
}
