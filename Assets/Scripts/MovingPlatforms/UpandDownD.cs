using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDownD : MonoBehaviour {
    private UpandDownPlatform platform;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject movingPlatform = GameObject.Find("UpandDownPlatform");
        UpandDownPlatform platformScript = movingPlatform.GetComponent<UpandDownPlatform>();
        if (collision.CompareTag("MovingPlatform"))
        {
            collision.GetComponent<UpandDownPlatform>().goingUp = true; 
            //Changes the direction of the moving platform to up
        }
    }
}
