using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {

    public int moveSpeed = 200;
    public bool border;

    private P1controller p;

	// Use this for initialization
	void Start () {
		
	}

    public void setPlayer(P1controller p)
    {
        this.p = p;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(1, 0) * Time.deltaTime * moveSpeed);

        float firemoveHorizontal = Input.GetAxis("Horizontal");
        float firemoveVertical = Input.GetAxis("Vertical");

        if ((this.transform.position).x >= BackgroundScript.maxX || (this.transform.position).x <= BackgroundScript.minX || (this.transform.position).y >= BackgroundScript.maxY || (this.transform.position).y <= BackgroundScript.minY)
        {
            Destroy(this.gameObject);
            Move.moveValue -= 1;
        }
    }

    public void OnTriggerEnter2D (Collider2D collision)
  {
        if (collision.gameObject.tag == "PurpleIcicle")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Move.moveValue -= 1;
            Score.scoreValue += PurpleIcicle.score;
        }
        else if (collision.gameObject.tag == "BlueIcicle")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Move.moveValue -= 1;
            Score.scoreValue += BlueIcicle.score;
        }
        else if (collision.gameObject.tag == "WhiteIcicle")
           {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                Move.moveValue -= 1;
               // Score.scoreValue += WhiteIcicle.score;
        }
        else if (collision.gameObject.tag == "DBlueIcicle")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Move.moveValue -= 1;
            Score.scoreValue += DBlueIcicle.score;
        }
        p.CheckIfGameWon();
    }
}
