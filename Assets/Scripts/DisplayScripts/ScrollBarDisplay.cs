using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBarDisplay : MonoBehaviour {
    Scrollbar healthB;
	// Use this for initialization
	void Start () {
        healthB = GetComponent<Scrollbar>();
	}
	
	// Update is called once per frame
	void Update () {
        bossTakenDamage();
    }
    public void bossTakenDamage()
    {
        GameObject Boss = GameObject.Find("ZombieBoss");
        BossController bossScript = Boss.GetComponent<BossController>();
        healthB.size = (bossScript.health/200f); 
        //Size of the health bar is proportionate to the health of the boss
    }
}
