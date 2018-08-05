using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleIcicle : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        print("hit");
        if (collision.gameObject.tag == "fireball")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Score.scoreValue += 10;
            //Move.moveValue -= 1;
        }
    }
}

	

