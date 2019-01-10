using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    private Rigidbody2D platform;
    public bool goingRight;
	// Use this for initialization
	void Start () {
        goingRight = true; //Starts off moving to the right
        platform = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        movement();
	}
    public void movement()
    {
        if (goingRight) //Platform moves right
        {
            platform.velocity = new Vector3(2, 0, 0);
        }
        if(!goingRight) //Platform moves left
        {
            platform.velocity = new Vector3(-2, 0, 0);
        }
    }
}
