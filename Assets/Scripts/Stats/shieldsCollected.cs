using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shieldsCollected : MonoBehaviour {
    Text text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject stat = GameObject.Find("SStat");
        shieldStat shieldStat = stat.GetComponent<shieldStat>();
        text.text = (shieldStat.shieldsCollected + " shield(s) collected.");
        //Sets text to the number of shields collected
    }
}
