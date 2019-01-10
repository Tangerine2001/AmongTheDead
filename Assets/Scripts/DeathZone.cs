using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {
    private PlayerMovement Player;
    public float xValue;
    public float yValue;
    public float zValue;
    void Start()
    {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
        Vector3 playerPos = playerScript.transform.localPosition;
        this.xValue = playerPos.x;
        this.yValue = playerPos.y;
        this.zValue = playerPos.z;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
        GameObject collided = other.gameObject;
        if(collided.CompareTag("Player"))
        {
            collided.GetComponent<PlayerMovement>().deathByVoid();
        }
            playerScript.transform.localPosition.Set(xValue, yValue, zValue); //Respawns player at the starting point of the level
    }
}
