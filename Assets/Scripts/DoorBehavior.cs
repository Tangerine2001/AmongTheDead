using UnityEngine;
using System.Collections;

public class DoorBehavior : MonoBehaviour
{
    [SerializeField]
    public int titleScreen;

    public bool notEntered = true; //This is so the method will only run once
    void OnTriggerStay2D(Collider2D other)
    {
        GameObject title = GameObject.Find("TitleScreen");
        LevelComplete titlescript = title.GetComponent<LevelComplete>(); //Sets titlescript as the LevelComplete script under the object named TitleScreen
        GameObject objectCollided = other.gameObject; //Find the object that ran into the collider
        if (objectCollided.CompareTag("Player") && Input.GetKeyDown("up") && notEntered)
        {
            notEntered = false;
            objectCollided.GetComponent<PlayerMovement>().levelComplete(); //Runs the levelComplete method in the PlayerMovement script
        }
    }
}
