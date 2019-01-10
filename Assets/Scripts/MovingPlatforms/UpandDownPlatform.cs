using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDownPlatform : MonoBehaviour {
    private Rigidbody2D platform;
    public bool goingUp;
    // Use this for initialization
    void Start()
    {
        goingUp = true;
        platform = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    public void movement()
    {
        if (goingUp)
        {
            platform.velocity = new Vector3(0, 2, 0); //Platform moves up
        }
        if (!goingUp)
        {
            platform.velocity = new Vector3(0, -2, 0); //Platform moves down
        }
    }
}
