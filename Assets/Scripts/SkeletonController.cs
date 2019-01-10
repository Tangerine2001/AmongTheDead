using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour {
    public bool seePlayer;
	// Use this for initialization
	void Start () {
        seePlayer = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ifPlayerInRange()
    {
        if (seePlayer)
        {
            attackPlayer();
        }
    }
    public void attackPlayer()
    {

    }
}
