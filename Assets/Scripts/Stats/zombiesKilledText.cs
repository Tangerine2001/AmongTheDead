using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombiesKilledText : MonoBehaviour {
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        GameObject stat = GameObject.Find("KStat");
        zombiekstat killStat = stat.GetComponent<zombiekstat>();
        text.text = (killStat.zombieDeadNum + " kills.");
        //Sets text to the number of zombies killed
	}
}
