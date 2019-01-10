using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBorderR : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject Boss = GameObject.Find("ZombieBoss");
        BossController bossScript = Boss.GetComponent<BossController>();
        if (collision.CompareTag("Boss"))
        {
            bossScript.facingRight = false; //Changes direction of boss
        }
    }
}
