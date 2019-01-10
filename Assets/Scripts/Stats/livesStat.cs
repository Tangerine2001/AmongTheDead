using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livesStat : MonoBehaviour {
    public int heartsCollected;
	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(transform.gameObject); //Script doesn't reset between scenes
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
