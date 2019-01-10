using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombiekstat : MonoBehaviour {

	public int zombieDeadNum;
	// Use this for initialization
	void Awake() 
	{
		DontDestroyOnLoad (transform.gameObject); //Script is not reset or destroyed when changing scenes
    }

	
	// Update is called once per frame
	void Update () 
	{
        
    }
}
