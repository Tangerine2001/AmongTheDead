using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement player = Player.GetComponent<PlayerMovement>();
        Vector3 playerPos = player.transform.localPosition;
        playerPos.x = player.xValue - 510;
        playerPos.y = player.yValue + 263;
        Vector3 textPos = playerPos;
        transform.localPosition = textPos;
    }
}
