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
    public GameObject NextButton;


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
        NextButton.SetActive(false);

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
        //rb.velocity = movement * speed;

        myAnim.SetFloat("speed", Mathf.Abs(moveHorizontal));

        rb.velocity = new Vector2(moveHorizontal, moveVertical)*speed;

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
        // wait 
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
        Debug.DrawLine(playerPosition, (mousePosition - playerPosition) * 100, Color.cyan);

        if (distantx < 0)
        {
            rotation = rotation - 180;
        }
        if (mousex <= BackgroundScript.maxX && mousex >= BackgroundScript.minX && mousey <= BackgroundScript.maxY && mousey >= BackgroundScript.minY)
        {
            Instantiate(fireball, this.transform.position, Quaternion.Euler(0, 0, rotation));
            fireball.setPlayer(this);
            //Move.moveValue -= 1;
        }            
    }

    public void CheckIfGameWon()
    {
        print(Score.scoreValue);

        if ((Score.scoreValue >= Goal.goalValue))
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
        NextButton.SetActive(true);
        gameWin = true;
        Destroy(this.gameObject);

    }
    public void LoseGame()
    {
        LevelLose.SetActive(true);
        RestartButton2.SetActive(true);
        gameLose = true;
        Destroy(this.gameObject);
    }
}
