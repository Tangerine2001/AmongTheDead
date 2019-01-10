using UnityEngine;
using System.Collections;

public class ExtraLife : MonoBehaviour {

    private PlayerMovement Player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject Player = GameObject.Find("Player");
            PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
            playerScript.lives += 1; //Gives the player an extra life
            GameObject stat = GameObject.Find("LStat");
            livesStat lStat = stat.GetComponent<livesStat>();
            lStat.heartsCollected += 1; //Adds a 1 to the heart statistic
            Destroy(gameObject); //Remvoes the heart from the game
        }
    }
}
