using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldIconPickup : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject Shield = GameObject.Find("shieldIcon");
        ShieldIcon shieldScript = Shield.GetComponent<ShieldIcon>();
        if (other.CompareTag("Player") && !shieldScript.pickup)
        { 
            shieldScript.pickup = true; //Sets the pickup bool in the ShieldIcon script to true
            GameObject stat = GameObject.Find("SStat");
            shieldStat shieldStat = stat.GetComponent<shieldStat>();
            shieldStat.shieldsCollected += 1; //Adds a shields collected statistic
            Destroy(gameObject); //Removes the shield from the level
        }
	}
}
