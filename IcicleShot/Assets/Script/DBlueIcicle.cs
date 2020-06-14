using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBlueIcicle : MonoBehaviour
{
    public static int score = 20;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void OnTriggerEnter2D(Collider2D collision)
    {
        print("hit");
        if (collision.gameObject.tag == "fireball")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Score.scoreValue += 20;
           // Move.moveValue -= 1;
        }

    }
    */
}
