using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D player;
    private PlayerMovement playerScript;
    private BoxCollider2D ground;
    public Animator playerAnim;
    public Transform playerPos;
    public bool facingRight;
    public bool isJumping;
    public bool grounded;
    public bool attack;
    public int lives = 3;
    public bool inFrontOfDoor = false;

    public float xValue;
    public float yValue;
    public float zValue;
    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerScript = GetComponent<PlayerMovement>();
        ground = GameObject.Find("isGrounded").GetComponent<BoxCollider2D>();
        facingRight = true;
        isJumping = false;
        Vector3 playerPos = transform.localPosition; 
        this.xValue = playerPos.x; //Current x position of player. Set when level begins. Used in DeathZone script
        this.yValue = playerPos.y; //Current y position of player. Set when level begins. Used in DeathZone script
        this.zValue = playerPos.z; //Current z position of player. Set when level begins. Used in DeathZone script
    }
    // Update is called once per frame
    void Update () {
        float horizontalMovement = Input.GetAxis("Horizontal"); 
        //Horizontal means left or right arrow keys or the "a" and "d" keys.
        //Left arrow and "a" set the float to -1
        //Right arrow and "d" set the float to 1
        checkAttack();
        playerMove(horizontalMovement * 5);
        Speed(horizontalMovement);
        flipPlayer(horizontalMovement);
        playerJump();
        checkGrounded();
        checkAlive();
	}

    private void checkAlive() //Checks if the player is alive
    {
        if(lives <= 0)
        {
            playerAnim.SetBool("dead", true); //Runs the death animation
            StartCoroutine(deathDelay());
        }
    }
    private void playerJump()
    {
        if (Input.GetKeyDown("up") && !isJumping) //Allows player to jump as long as he is not already jumping
        {
            player.AddForce(Vector2.up * 540);
        } 
    }
    private void checkGrounded()
    {
        if (grounded)
        {
            playerAnim.SetBool("jump", false); //Stop running the jump animation if the player is on the ground
        }
        if (!grounded)
        {
            playerAnim.SetBool("jump", true); //Start running the jump animation if the player is in the air
        }
    }
    private void Speed(float h)
    {
            playerAnim.SetFloat("speed", Mathf.Abs(h)); 
        //h is the float set by Input.GetAxis above in the Update method
        //This sets the variable "speed" in the animator in the Unity IDE to the absolute value of the speed
        //If the value is greater than 1, the run animation plays. Otherwise, the idle animation plays
    }
    private void playerMove(float h)
    {
        if (lives > 0)
        {
            player.velocity = new Vector2(h * 1.5f, player.velocity.y); 
            //Sets player speed on the x and the y axis
        }
    }
    private void flipPlayer(float h)
    {
        if ((h > 0 && !facingRight) || (h < 0 && facingRight)) //Flips the player so that he faces the direction he's going
        {
            facingRight = !facingRight;
            Vector3 playerFlip = transform.localScale;
            playerFlip.x *= -1;
            transform.localScale = playerFlip;
        }
    }
    private void checkAttack()
    {
        if(Input.GetKeyDown("space") && !playerAnim.GetBool("attack"))
        {
            playerAnim.SetBool("attack", true); //Runs attack animation
            attack = true; //Sets attack to true for use in other scripts
            StartCoroutine(Delay());
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.8f); //Waits 0.8 seconds then runs the next line of code
        playerAnim.SetBool("attack", false); //Stop the attack animation
        attack = false; //Sets attack to false
    }   

    public void deathByVoid()
    {
        lives -= 1; //Player loses a life
        transform.localPosition = new Vector3(xValue,yValue,zValue);
        //Teleports player to his beginning position
    }
    public void attackByZombie()
    {
        GameObject Shield = GameObject.Find("shieldIcon");
        ShieldIcon shieldScript = Shield.GetComponent<ShieldIcon>();
        if(shieldScript.pickup)
        {
            shieldScript.pickup = false; //Removes shield if a shield is attached
        } else
        {
            lives -= 1; //If there is no shield, then the player loses a life
        }
    }
    public void attackByBoss()
    {
        GameObject Shield = GameObject.Find("shieldIcon");
        ShieldIcon shieldScript = Shield.GetComponent<ShieldIcon>();
        if (shieldScript.pickup)
        {
            shieldScript.pickup = false; //Removes shield if a the player has shield
            lives -= 2; //Player loses 2 lives
        }
        else
        {
            lives -= 3; //Player loses 3 lives
        }
    }
    IEnumerator deathDelay()
    {
        GameObject title = GameObject.Find("TitleScreen");
        LevelComplete titlescript = title.GetComponent<LevelComplete>();
        Destroy(ground);
        grounded = false; //Prevents player from jumping when dead
        yield return new WaitForSeconds(1.5f); //Wait 1.5 seconds
        playerAnim.SetBool("dead", false); //Stops the death animation
        Application.LoadLevel(titlescript.titleScreen); //Loads the title screen with levels that the player has unlocked
    }
    public void levelComplete()
    {
        GameObject title = GameObject.Find("TitleScreen");
        LevelComplete titlescript = title.GetComponent<LevelComplete>();
        titlescript.levelComplete(); //Runs the levelComplete method in the LevelComplete script
    }
    public void addKillStat()
    {
        GameObject stat = GameObject.Find("KStat");
        zombiekstat zstat = stat.GetComponent<zombiekstat>();
        zstat.zombieDeadNum += 1; //Adds a zombie kill statistic
    }
}
