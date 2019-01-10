using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonRange : MonoBehaviour {
    private SkeletonController skeleton;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            skeleton.seePlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            skeleton.seePlayer = false;
        }
    }
}
