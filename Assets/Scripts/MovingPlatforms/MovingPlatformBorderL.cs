using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformBorderL : MonoBehaviour {
    private MovingPlatform platform;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject movingPlatform = GameObject.Find("MovingPlatform");
        MovingPlatform platformScript = movingPlatform.GetComponent<MovingPlatform>();
        if(collision.CompareTag("MovingPlatform"))
        {
            platformScript.goingRight = true; //Changes the platform direction to right
        }
    }
}
