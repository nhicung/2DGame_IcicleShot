using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicbutton : MonoBehaviour {

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "GamePlay")
        {
            Destroy(this.gameObject);
        }

    }
}
