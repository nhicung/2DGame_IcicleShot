using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class story2 : MonoBehaviour
{

    public GameObject Story1;
    public GameObject Story2;
    public GameObject Story3;
    public GameObject Story4;
    public GameObject Story5;
    public GameObject Story6;
    public GameObject Story7;
    public GameObject Texture1;
    public GameObject Texture2;
    public GameObject Texture3;
    public GameObject Texture4;
    public GameObject Texture5;
    public GameObject Texture6;
    public GameObject Texture7;
    public GameObject NextButton;
    public GameObject BackButton;
    public GameObject MusicToggle;



    void Start()
    {
        Story1.SetActive(true);
        Texture1.SetActive(true);
        NextButton.SetActive(true);
        BackButton.SetActive(false);
        MusicToggle.SetActive(true);
        Story2.SetActive(false);
        Texture2.SetActive(false);
        Story3.SetActive(false);
        Texture3.SetActive(false);
        Story4.SetActive(false);
        Texture4.SetActive(false);
        Story5.SetActive(false);
        Texture5.SetActive(false);
        Story6.SetActive(false);
        Texture6.SetActive(false);
        Story7.SetActive(false);
        Texture7.SetActive(false);
    }

    public void PlayButton()
    {

       
         if (CountScript.count == 1)
        {
            Story1.SetActive(true);
            Texture1.SetActive(true);
            NextButton.SetActive(true);
            BackButton.SetActive(false);
            Story2.SetActive(false);
            Texture2.SetActive(false);
            Story3.SetActive(false);
            Texture3.SetActive(false);
            Story4.SetActive(false);
            Texture4.SetActive(false);
            Story5.SetActive(false);
            Texture5.SetActive(false);
            Story6.SetActive(false);
            Texture6.SetActive(false);
            Story7.SetActive(false);
            Texture7.SetActive(false);

        }
        if (CountScript.count == 2)
        { 
            Time.timeScale = 1f;
            Story1.SetActive(false);
            Texture1.SetActive(false);
            BackButton.SetActive(true);
            Story2.SetActive(true);
            Texture2.SetActive(true);
            Story3.SetActive(false);
            Texture3.SetActive(false);
            Story4.SetActive(false);
            Texture4.SetActive(false);
            Story5.SetActive(false);
            Texture5.SetActive(false);
            Story6.SetActive(false);
            Texture6.SetActive(false);
            Story7.SetActive(false);
            Texture7.SetActive(false);
        }

        else if (CountScript.count == 3)
        {
            Time.timeScale = 1f;
            Story1.SetActive(false);
            Texture1.SetActive(false);
            BackButton.SetActive(true);
            Story2.SetActive(false);
            Texture2.SetActive(false);
            Story3.SetActive(true);
            Texture3.SetActive(true);
            Story4.SetActive(false);
            Texture4.SetActive(false);
            Story5.SetActive(false);
            Texture5.SetActive(false);
            Story6.SetActive(false);
            Texture6.SetActive(false);
            Story7.SetActive(false);
            Texture7.SetActive(false);

        }
        else if (CountScript.count == 4)
        {
            Time.timeScale = 1f;
            Story1.SetActive(false);
            Texture1.SetActive(false);
            BackButton.SetActive(true);
            Story2.SetActive(false);
            Texture2.SetActive(false);
            Story3.SetActive(false);
            Texture3.SetActive(false);
            Story4.SetActive(true);
            Texture4.SetActive(true);
            Story5.SetActive(false);
            Texture5.SetActive(false);
            Story6.SetActive(false);
            Texture6.SetActive(false);
            Story7.SetActive(false);
            Texture7.SetActive(false);
        }
        else if (CountScript.count == 5)
        {
            Time.timeScale = 1f;
            Story1.SetActive(false);
            Texture1.SetActive(false);
            BackButton.SetActive(true);
            Story2.SetActive(false);
            Texture2.SetActive(false);
            Story3.SetActive(false);
            Texture3.SetActive(false);
            Story4.SetActive(false);
            Texture4.SetActive(false);
            Story5.SetActive(true);
            Texture5.SetActive(true);
            Story6.SetActive(false);
            Texture6.SetActive(false);
            Story7.SetActive(false);
            Texture7.SetActive(false);
        }
        else if (CountScript.count == 6)
        {
            Time.timeScale = 1f;
            Story1.SetActive(false);
            Texture1.SetActive(false);
            BackButton.SetActive(true);
            Story2.SetActive(false);
            Texture2.SetActive(false);
            Story3.SetActive(false);
            Texture3.SetActive(false);
            Story4.SetActive(false);
            Texture4.SetActive(false);
            Story5.SetActive(false);
            Texture5.SetActive(false);
            Story6.SetActive(true);
            Texture6.SetActive(true);
            Story7.SetActive(false);
            Texture7.SetActive(false);
        }
        else if (CountScript.count == 7)
        {
            Time.timeScale = 1f;
            Story1.SetActive(false);
            Texture1.SetActive(false);
            BackButton.SetActive(true);
            Story2.SetActive(false);
            Texture2.SetActive(false);
            Story3.SetActive(false);
            Texture3.SetActive(false);
            Story4.SetActive(false);
            Texture4.SetActive(false);
            Story5.SetActive(false);
            Texture5.SetActive(false);
            Story6.SetActive(false);
            Texture6.SetActive(false);
            Story7.SetActive(true);
            Texture7.SetActive(true);
        }
        CountScript.count -= 1;
    }
}
