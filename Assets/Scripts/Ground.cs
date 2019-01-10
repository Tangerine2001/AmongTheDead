using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

    private PlayerMovement Player;

    void Start()
    {
        
    }
	void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("MovingPlatformBorder")) //This is so the player isn't able to able on thin air
        {
            GameObject Player = GameObject.Find("Player");
            PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
            playerScript.isJumping = false;
            playerScript.grounded = true;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (!other.CompareTag("MovingPlatformBorder"))
        {
            GameObject Player = GameObject.Find("Player");
            PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
            playerScript.isJumping = false;
            playerScript.grounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
        playerScript.isJumping = true;
        playerScript.grounded = false;
    }
}
