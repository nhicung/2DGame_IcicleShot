using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour {

    // Use this for initialization
    public static bool GameIsPaused = false;
    public GameObject pausemenu;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            { Resume();
            }
            else {

                Pause();
            }
        }
	}
    void Resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()

    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

