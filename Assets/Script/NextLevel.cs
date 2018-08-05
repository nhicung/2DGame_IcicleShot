using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void PlayButton()
    {
        Move.moveValue = 4;
        SceneManager.LoadScene("level2select");
    }
}
