using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour {
    Text textLocation;
    void Start()
    {
        textLocation = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement player = Player.GetComponent<PlayerMovement>();
        textLocation.text = ("x" + player.lives);
        //Displays the amount of lives the player has
    }
}
