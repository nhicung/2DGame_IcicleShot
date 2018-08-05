using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelscreencontroller : MonoBehaviour
{
    public GameObject Select;

    void Start()
    {
        Select.SetActive(false);

    }
    public void PlayButton()
    {
        //Application.LoadLevel("GamePlay");
        Select.SetActive(true);
        SceneManager.LoadScene("levelselect");

    }
}
