using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selector : MonoBehaviour
{
    public GameObject Selector; 

    // Use this for initialization
    void Start()
    {
        Selector.SetActive(false);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChooseLevel1()
    {
        Selector.SetActive(true);
        //Time.timeScale = 4f;
        SceneManager.LoadScene("level1select");
    }
   
}
