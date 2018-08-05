using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonlv1 : MonoBehaviour {

    public GameObject level1 = null;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    public void CreateObject()
    
        {
       
        Instantiate(level1, this.transform.position, Quaternion.identity);

    }
}
