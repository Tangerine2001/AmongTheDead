using UnityEngine;
using System.Collections;
//Script not used
public class HeartDisplay : MonoBehaviour {
    private PlayerMovement Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        playerTurned(); 
	}
    private void playerTurned()
    {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
        Vector3 playerPos = playerScript.transform.localPosition;
        Vector3 heartPos = transform.localPosition;
        heartPos.x = playerPos.x + 15.5f;
        heartPos.y = playerPos.y + 9.4f;
        transform.localPosition = heartPos;
    }
}
