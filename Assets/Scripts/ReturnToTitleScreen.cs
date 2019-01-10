using UnityEngine;
using System.Collections;

public class ReturnToTitleScreen : MonoBehaviour
{
    public bool levelBeat = false;
    private PlayerMovement Player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkESC();
        ifGameWon();
        skipToEnd();
    }
    private void checkESC()
    {
        GameObject door = GameObject.Find("woodenDoor");
        DoorBehavior doorscript = door.GetComponent<DoorBehavior>();
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel(doorscript.titleScreen - 1); //Loads the titlescreen that only has the levels the player has unlocked
        }
    }
    private bool ifGameWon()
    {
        GameObject title = GameObject.Find("TitleScreen");
        LevelComplete titlescript = title.GetComponent<LevelComplete>();
        if (titlescript.titleScreen > 3) //Ensures the title screen doesn't move past the 3rd one
        {
            titlescript.titleScreen = 3;
            return true;
        }
        return false;
    }
    private void skipToEnd()
    {
        if (Input.GetKey(KeyCode.F12)) //This is a cheat. Press F12 to access all levels
        {
            GameObject title = GameObject.Find("TitleScreen");
            LevelComplete titlescript = title.GetComponent<LevelComplete>();
            titlescript.titleScreen = 3;
            Application.LoadLevel(titlescript.titleScreen);
        }
    }
}
