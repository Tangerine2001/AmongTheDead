using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heartsCollectedText : MonoBehaviour {
    Text text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>(); //text is now the Text component, which can be changed
    }

    // Update is called once per frame
    void Update()
    {
        GameObject stat = GameObject.Find("LStat");
        livesStat hStat = stat.GetComponent<livesStat>();
        text.text = (hStat.heartsCollected + " heart(s) collected."); 
        //Sets the text to the number of hearts the player has collected
    }
}
