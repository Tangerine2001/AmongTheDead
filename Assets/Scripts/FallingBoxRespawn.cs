using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBoxRespawn : MonoBehaviour {
    private GameObject prefabBox;
    private Transform boxTrans;
    private void Start()
    {
        prefabBox = GameObject.Find("SpikeblockSteelC"); //Template box
    }
    private void OnTriggerEnter2D(Collider2D box)
    {
        if(box.CompareTag("Box"))
        {
            boxTrans = box.GetComponent<Transform>();
            Vector3 boxPos = boxTrans.transform.localPosition;
            boxPos.y += 11f;
            Instantiate(prefabBox, boxPos, Quaternion.identity); //Spawns the template box at the position so that the boxes reappear
            Destroy(box.GetComponent<SpriteRenderer>()); //Destroys the box that has already fallen
        }
    }
}
