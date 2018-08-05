using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class story1 : MonoBehaviour {

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
    public float sec = 3f;


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
        
        if (CountScript.count == 0 )
        {
            //Select.SetActive(true);
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
            //SceneManager.LoadScene("levelselect");

        }

        else if (CountScript.count == 1)
        {
            //Select.SetActive(true);
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
        else if (CountScript.count == 2)
        {
            //Select.SetActive(true);
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
        else if (CountScript.count == 3)
        {
            //Select.SetActive(true);
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
        else if (CountScript.count == 4)
        {
            //Select.SetActive(true);
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
        else if (CountScript.count == 5)
        {
            //Select.SetActive(true);
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
        else if (CountScript.count == 6)
        {
            SceneManager.LoadScene("levelscreen");
        }
        CountScript.count += 1;
    }
}
