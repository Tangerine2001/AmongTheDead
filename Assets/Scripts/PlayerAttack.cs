using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{

    private PlayerMovement Player;
    private ZombieScript Zombie;

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
        GameObject objectCollided = other.gameObject;
        if (objectCollided.CompareTag("Enemy") && playerScript.attack)
        {
            objectCollided.GetComponent<ZombieScript>().damageTaken(); //Zombie takes damage
            playerScript.addKillStat(); //Add 1 to the kill statistic
        }
        if (objectCollided.CompareTag("Boss") && playerScript.attack)
        {
            objectCollided.GetComponent<BossController>().damageTaken(); //Boss takes damage
            objectCollided.GetComponent<BossController>().facingRight = !objectCollided.GetComponent<BossController>().facingRight; //Boss changes direction when hit to make him more difficult to kill
            playerScript.attack = false; //This is so the method doesn't repeatedly for the 0.8 seconds that playerscript.attack is true
        }
    }
    void OnTriggerStay2D(Collider2D other) 
    //Same code as OnTriggerEnter2D, but runs constantly if the object the collided with this one doesn't exit
    {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
        GameObject objectCollided = other.gameObject;
        if (objectCollided.CompareTag("Enemy") && playerScript.attack)
        {
            objectCollided.GetComponent<ZombieScript>().damageTaken();
            playerScript.addKillStat();
        }
        if (objectCollided.CompareTag("Boss") && playerScript.attack)
        {
            objectCollided.GetComponent<BossController>().damageTaken();
            objectCollided.GetComponent<BossController>().facingRight = !objectCollided.GetComponent<BossController>().facingRight;
            playerScript.attack = false;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2); //A 2 second delay begins before running the next line of code
    }
}
