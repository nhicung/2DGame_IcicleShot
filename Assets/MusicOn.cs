using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicOn : MonoBehaviour {

    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music2");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "level 2")
        {
            Destroy(this.gameObject);
        }

    }
}

