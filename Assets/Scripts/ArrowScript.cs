using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
        transform.position = Vector3.Lerp(transform.position, playerScript.transform.localPosition, 5 * Time.deltaTime);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
