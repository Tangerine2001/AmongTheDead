using UnityEngine;
using System.Collections;

public class ZombieAttack : MonoBehaviour {
    [SerializeField]
    public string zombieName;

    private Rigidbody2D Zombie;
    private PolygonCollider2D zombieCollider;
    private ZombieScript zombieScript;
    private Transform location;
    public Animator zombieAnim;


    void OnTriggerEnter2D(Collider2D other)
    {
        Zombie = GetComponent<Rigidbody2D>();
        zombieCollider = GetComponent<PolygonCollider2D>();
        zombieAnim = GetComponent<Animator>();
        if (other.CompareTag("Player"))
        {
            attackPlayer(); //Runs the attackPlayer method
            GameObject Player = GameObject.Find("Player");
            PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
            playerScript.attackByZombie(); //Runs the attackByZombie method located in the PlayerMovement script
        }
    }
    public void attackPlayer()
    {
        zombieAnim.SetBool("attack", true); //Runs the attack animation
        StartCoroutine(Delay());
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.8f); //Wait 0.8 seconds
        zombieAnim.SetBool("attack", false); //Stops the attack animation
    }
}
