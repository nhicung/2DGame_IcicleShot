using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P1controller : MonoBehaviour
{
    public float speed;
    public fireball fireball;
    //public LayerMask whatToHit;
    private Rigidbody rb;
    Animator myAnim;
    bool facingright;
    public GameObject LevelComplete;
    public GameObject LevelLose;
    public GameObject RestartButton2;

    public Text score;
    public bool gameWin;
    public bool gameLose;
    public bool border;

    public static bool paused;

    public float restartDelay = 5f;

    float restartTimer;
    public Move moveValue;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        facingright = true;
        myAnim = GetComponent<Animator>();
        LevelComplete.SetActive(false);
        LevelLose.SetActive(false);
        RestartButton2.SetActive(false);
        // youWinText.SetActive(false);
        paused = false;
    }

    void FixedUpdate()
    {
        if (Move.moveValue == 0)
        {
            CheckIfGameWon();
            return;
        }
        print("paused" + paused);
        if (paused)
        {
            return; 
        }
       
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        if ((this.transform.position).x >= BackgroundScript.maxX && (moveHorizontal > 0))
        {
            moveHorizontal=0;
        }
        else if ((this.transform.position).x <= BackgroundScript.minX && (moveHorizontal < 0))
        {
            moveHorizontal=0;
        }



        Vector3 movement = new Vector3(moveHorizontal, moveVertical);

        myAnim.SetFloat("speed", Mathf.Abs(moveHorizontal));

        rb.velocity = new Vector2(moveHorizontal, moveVertical);


        /*if (Move.moveValue <=0 )
        {
            myAnim.SetTrigger("LevelLose");

            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene("GamePlay");
            }
        }*/

        if (moveHorizontal > 0 && !facingright)
        {
            flip();
        }
        else if (moveHorizontal < 0 && facingright)
        {
            flip();
        }
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
        CheckIfGameWon();
    }

    void flip()
    {
        facingright = !facingright;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void shoot()
    {
        float mousex = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        float mousey = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToViewportPoint(Input.mousePosition).x, Camera.main.ScreenToViewportPoint(Input.mousePosition).y);

        float playerx = (this.transform.position).x;
        float playery = (this.transform.position).y;
        Vector2 playerPosition = new Vector2(this.transform.position.x, this.transform.position.y);

        float distantx = (mousex - playerx);
        float distanty = (mousey - playery);
        float rotation = Mathf.Atan(distanty / distantx) * Mathf.Rad2Deg;
        //RaycastHit2D hit = Physics2D.Raycast(playerPosition, mousePosition - playerPosition, 100, whatToHit);
        Debug.DrawLine(playerPosition, (mousePosition - playerPosition) * 100, Color.cyan);
        //if (hit.collider != null)
        //{
        //   Debug.DrawLine(playerPosition, hit.point, Color.red);
        //}
        //float rotation = Vector2.SignedAngle(new Vector2(mousex, mousey), new Vector2(playerx, playery));

        if (distantx < 0)
        {
            rotation = rotation - 180;
        }
        if (mousex <= BackgroundScript.maxX && mousex >= BackgroundScript.minX && mousey <= BackgroundScript.maxY && mousey >= BackgroundScript.minY)
        {
            Instantiate(fireball, this.transform.position, Quaternion.Euler(0, 0, rotation));
            Move.moveValue -= 1;
        }
            //Instantiate(fireball, this.transform.position, Quaternion.Euler(0, 0, rotation));
    }

    public void CheckIfGameWon()
    {
        if ((Score.scoreValue >= Goal.goalValue) && Move.moveValue >= 0)
        {
            WinGame();
        }
        else if ((Score.scoreValue < Goal.goalValue) && Move.moveValue == 0)
        {
            LoseGame();
        }
    }

    public void WinGame()
    {
        LevelComplete.SetActive(true);
        gameWin = true;
       // transform.SetAsLastSibling();


    }
    public void LoseGame()
    {
        LevelLose.SetActive(true);
        gameLose = true;
        //transform.SetAsLastSibling();
    }
}

/* how to limit player move in screen:
 * // X axis
if (transform.position.x <= -4.3f) {
 transform.position = new Vector2(-4.3f, transform.position.y);
} else if (transform.position.x >= 4.3f) {
 transform.position = new Vector2(4.3f, transform.position.y);
}

// Y axis
if (transform.position.y <= -2.7f) {
 transform.position = new Vector2(transform.position.x, -2.7f);
} else if (transform.position.y >= 2.7f) {
 transform.position = new Vector2(transform.position.x, 2.7f);
}*/


// myAnim.SetFloat("speed", Mathf.Abs(moveHorizontal));
//    Animator myAnim;
