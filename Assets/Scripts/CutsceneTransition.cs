using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTransition : MonoBehaviour {
    [SerializeField]
    public int titlescene;
    [SerializeField]
    public int seconds;
	// Use this for initialization
	void Start () {
        StartCoroutine(Delay());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(seconds); //Wait before loading the next scene
        Application.LoadLevel(titlescene); //Loads the title scene specified
    }
}
