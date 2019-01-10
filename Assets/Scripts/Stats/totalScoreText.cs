using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalScoreText : MonoBehaviour {
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        GameObject sstat = GameObject.Find("SStat");
        shieldStat shieldStat = sstat.GetComponent<shieldStat>();
        GameObject kstat = GameObject.Find("KStat");
        zombiekstat killStat = kstat.GetComponent<zombiekstat>();
        GameObject stat = GameObject.Find("LStat");
        livesStat hStat = stat.GetComponent<livesStat>();
        float totalScore = shieldStat.shieldsCollected + (killStat.zombieDeadNum * 100) + hStat.heartsCollected;
        //Each shield and heart is worth 1 point while each zombie kill is worth 100
        //totalScore is the sum of all the other scores and their point value
        text.text = ("" + totalScore);
        //Displays the score
    }
}
