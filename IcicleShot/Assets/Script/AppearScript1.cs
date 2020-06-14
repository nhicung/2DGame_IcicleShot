using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AppearScript1 : MonoBehaviour {

    public GameObject settingbar;
    // Use this for initialization
    void Start () {
        settingbar.SetActive(false);
	}
	
	// Update is called once per frame
	public void PlayButton() {
        settingbar.SetActive(true);
        //Instantiate(settingbar, this.transform.position, Quaternion.identity);
    }
}
