using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {

    public int moveSpeed = 200;
    public bool border;
   // public PurpleIcicle PurpleIcicle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(1, 0) * Time.deltaTime * moveSpeed);

        float firemoveHorizontal = Input.GetAxis("Horizontal");
        float fireSmoveVertical = Input.GetAxis("Vertical");

        if ((this.transform.position).x >= BackgroundScript.maxX && (firemoveHorizontal > 0)&&(this.transform.position).y >= BackgroundScript.maxY && (firemoveHorizontal > 0))
        {
            Destroy(this.gameObject);
        }
        else if ((this.transform.position).x <= BackgroundScript.minX && (firemoveHorizontal < 0)&& (this.transform.position).x <= BackgroundScript.minX && (firemoveHorizontal < 0))
        {
            Destroy(this.gameObject);
        }
        // Destroy(this.gameObject,2);
    }

 /* public void OnCollisionEnter (Collision collision)
  {
        if (collision.gameObject.tag == "PurpleIcicle")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
   }*/
}
