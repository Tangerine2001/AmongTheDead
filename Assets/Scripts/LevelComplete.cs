using UnityEngine;
using System.Collections;

public class LevelComplete : MonoBehaviour
{
    public int titleScreen = 0;
    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject); 
        //The script doesn't reset between scenes and is never destroyed
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void levelComplete() //Loads the next level
    {
        GameObject door = GameObject.Find("woodenDoor");
        DoorBehavior doorscript = door.GetComponent<DoorBehavior>();
        titleScreen += 1;
        Application.LoadLevel(doorscript.titleScreen);
    }
}
