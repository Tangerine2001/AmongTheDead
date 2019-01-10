using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour {
    private GameObject zombie;
    public Animator bossAnim;
    private Collider2D bossCollider;
    private BossController bossScript;
    private Rigidbody2D boss;
    public float health = 300f;
    public bool facingRight;
    public bool alive = true;
    void Start()
    {
        zombie = GameObject.Find("ZombieC");
        bossAnim = GetComponent<Animator>();
        bossAnim.SetBool("alive", true);
        boss = GetComponent<Rigidbody2D>();
        bossCollider = GetComponent<PolygonCollider2D>();
        bossScript = GetComponent<BossController>();
        facingRight = true;
        summonZombies(); //Starts the summon zombie loop
        alive = true;
    }


    void Update()
    {
        if (bossAnim.GetBool("alive"))
        {
            bossWalk();
        }
        checkAlive();

    }
    public void checkAlive()
    {
        if (health <= 0)
        {
            bossAnim.SetBool("alive", false);
            alive = false;
            Destroy(boss); //Removes the gravity and mass
            Destroy(bossCollider); //Allows player to pass through boss
            Destroy(bossScript); //Script is destroyed
            foreach (Transform child in gameObject.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            transform.Translate(Vector3.down * 2f); //This is to match up the animation with the ground
            health = 9999; //This is so the program doesn't run more than once
        }
    }
    public void bossWalk()
    {
        if(facingRight) //Moves right if facing right
        {
            Vector3 direction = transform.localScale;
            direction.x = 3; //A positive x scale makes the sprite face right
            transform.localScale = direction;
            boss.velocity = new Vector3(3, 0, 0);
        }
        if (!facingRight) //Moves right if facing right
        {
            Vector3 direction = transform.localScale;
            direction.x = -3;//A negative x scale makes the sprite face left
            transform.localScale = direction;
            boss.velocity = new Vector3(-3, 0, 0);
        }
    }
    public void attackPlayer() 
    {
        bossAnim.SetBool("attack", true);
        StartCoroutine(Delay());
        
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.8f);
        bossAnim.SetBool("attack", false);
        
    }
    public void damageTaken()
    {    
        health -= 10f;
        StartCoroutine(DamageDelay());
    }
    IEnumerator DamageDelay()
    {
        yield return new WaitForSecondsRealtime(0.8f);
    }
    public void summonZombies() //Summons zombie minions at a certain health
    {
        if (health <= 120 && health > 0)
        {
            Vector3 randomPos = new Vector3(Random.Range(495, 570), Random.Range(35, 40), -1);
            Instantiate(zombie, randomPos, Quaternion.identity);     
        }
        Invoke("Spawn", 2.5f); //Runs the Spawn method in 2.5 seconds
    }
    public void Spawn()
    {
        if (health <= 120 && health > 0)
        {
            Vector3 randomPos = new Vector3(Random.Range(495, 570), Random.Range(35, 40), -1);
            Instantiate(zombie, randomPos, Quaternion.identity);
        }
        Invoke("summonZombies", 2.5f); //Runs the summonZombies method, creating a loop
    }
}
