using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject Boss = GameObject.Find("ZombieBoss");
        BossController bossScript = Boss.GetComponent<BossController>();
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
        GameObject collided = collision.gameObject;
        if (collided.CompareTag("Player"))
        {
            bossScript.attackPlayer(); //Boss attacks player
            playerScript.attackByBoss(); //Player takes damage
        }
    }
}
