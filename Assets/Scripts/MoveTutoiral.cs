using UnityEngine;
using System.Collections;

public class MoveTutoiral : MonoBehaviour {
    private bool showing;
	// Use this for initialization
	void Start () {
        showing = true;
	}
	
	// Update is called once per frame
	void Update () {
        ifMove();
	}

    private void ifMove()
    {
        if ((showing == true) && (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0))
            Debug.Log("Player has moved.");
    }
}
