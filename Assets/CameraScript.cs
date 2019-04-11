using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject nextbutton;
    public GameObject backbutton;

    void Start()
    {
        backbutton.SetActive(false);
    }
    public void ShiftToScene () {

        Camera.main.transform.position = Camera.main.transform.position + new Vector3(9, 0, 0);
        nextbutton.SetActive(false);
        backbutton.SetActive(true);
    }
    public void ShiftToScene2()
    { 
        Camera.main.transform.position = Camera.main.transform.position + new Vector3(-9, 0, 0);
        nextbutton.SetActive(true);
        backbutton.SetActive(false);
    }
}
