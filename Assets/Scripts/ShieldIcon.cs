using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldIcon : MonoBehaviour {

	public bool pickup;
	private SpriteRenderer sprite;

	void Start () 
	{
		sprite = GetComponent<SpriteRenderer> ();
        sprite.enabled = false;
		pickup = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		checkPickup();
	}

	public void checkPickup() 
	{
		if (pickup) 
		{
			sprite.enabled = true; //Shield appears above player when equipped
		}
        if(!pickup)
        {
            sprite.enabled = false; //Shield disappears when lost
        }
	}
}
