using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{

    public Transform player;
    public float playerDistance;
    public float playerXAxis;
    public float moveSpeed;
    public bool grounded;
    public Rigidbody2D zombie;
    private BoxCollider2D zombieGrounded;
    public Animator zombieAnim;
    public bool onGround = false;
    public float followDistance = 13;
    // Use this for initialization
    void Start()
    {
        zombie = GetComponent<Rigidbody2D>();
        zombieGrounded = GetComponent<BoxCollider2D>();
        zombieAnim = GetComponent<Animator>();
        player = GameObject.Find("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(player.position, transform.position); 
        //Find the distance between player and the zombie
        followPlayer();
        LookAtPlayer();
    }
    public void followPlayer()
    {
        if (playerDistance < followDistance && onGround) 
            //Only follow player if he is not flying and the player is within range
        {
            chase();
            zombieAnim.SetFloat("speed", 1); //Runs the walk animation
        }
        if (playerDistance > followDistance)
            //Stop following the player
        {
            zombieAnim.SetFloat("speed", 0); //Stop the run animations and runs the idle animation
        }
    }
    void LookAtPlayer()
    {
        if (player.position.x - transform.position.x < 0)
        {
            Vector3 zombieScale = transform.localScale;
            zombieScale.x = -0.4f;
            transform.localScale = zombieScale;
        }
        else
        {
            Vector3 zombieScale = transform.localScale;
            zombieScale.x = 0.4f;
            transform.localScale = zombieScale;
        }

    }
    
    void chase() //Follows player on the x axis
    {
        zombie.velocity = new Vector2(-(transform.position.x - player.position.x), 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            onGround = true; //Detects 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))//Detects if the zombie is in the air or not
        {
            onGround = false; 
        }
    }

}