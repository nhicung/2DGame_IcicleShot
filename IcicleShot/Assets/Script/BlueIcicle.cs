using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueIcicle : MonoBehaviour {

    public static int score = 30;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*
    void OnTriggerEnter2D(Collider2D collision)
    {
        print("hit");
        if (collision.gameObject.tag == "fireball")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Score.scoreValue += 30;
        }
    }
    */
}
