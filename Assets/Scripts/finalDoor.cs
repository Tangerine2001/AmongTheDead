using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalDoor : MonoBehaviour {
    private Rigidbody2D door;
    public bool moving;
	// Use this for initialization
	void Start () {
        door = GetComponent<Rigidbody2D>();
        moving = true;
	}
	
	// Update is called once per frame
	void Update () {
        move();
    }
    public void move()
    {
        GameObject Boss = GameObject.Find("ZombieBoss");
        BossController bossScript = Boss.GetComponent<BossController>();
        if (bossScript == null && moving)
        {
            door.velocity = new Vector2(0, 2); //Door slowly moves upward
        } 
        if (!moving)
        {
            door.velocity = new Vector2(0, 0); //Door stops moving
        }
    }
}
