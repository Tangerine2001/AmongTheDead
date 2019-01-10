using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour {
    private Rigidbody2D Zombie;
    private CapsuleCollider2D zombieColliderC;
    private PolygonCollider2D zombieColliderP;
    private BoxCollider2D zombieColliderB;
    private ZombieScript zombieScript;
    private ZombieAttack zombieAttack;
    private Follow zombieFollow;
    private Transform location;
    public Animator zombieAnim;
    public int health = 10;
    public bool attacked;

    public bool alive = true;
    public float moveSpeed = 5;
	void Start () {
        Zombie = GetComponent<Rigidbody2D>();
        zombieColliderC = GetComponent<CapsuleCollider2D>();
        zombieColliderP = GetComponent<PolygonCollider2D>();
        zombieColliderB = GetComponent<BoxCollider2D>();
        zombieAnim = GetComponent<Animator>();
        zombieFollow = GetComponent<Follow>();
        zombieAttack = GetComponent<ZombieAttack>();
    }
	
	void Update () {
        checkAlive();

    }
    public void damageTaken()
    {
        health -= 10;
    }
    public void checkAlive()
    {
        if (health <= 0)
        {           
            zombieAnim.SetBool("dead", true); //Runs the death animation
            transform.Translate(Vector3.down * 0.2f);
            Zombie.gravityScale = 0; //Set the gravity on the zombie to 0 so that the zombie doesn't past ground
            Zombie.constraints = RigidbodyConstraints2D.FreezePositionX;
            Destroy(zombieColliderC);
            Destroy(zombieColliderP);
            Destroy(zombieColliderB);//Destroys all the colliders attached to the zombie
            Destroy(zombieAttack); //Removes the attack script
            Destroy(zombieFollow); //Removes the follow script
            health = 10000; //Method does not run on repeat
            alive = false;
        }
    }
}
