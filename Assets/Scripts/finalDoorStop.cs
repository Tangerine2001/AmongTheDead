using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalDoorStop : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject door = GameObject.Find("woodenDoor");
        finalDoor fDoor = door.GetComponent<finalDoor>();
        if (collision.CompareTag("door"))
        {
            fDoor.moving = false; //Stops the movement of the door
        }
    }
}
