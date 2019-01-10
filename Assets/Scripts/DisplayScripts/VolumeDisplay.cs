using UnityEngine;
using System.Collections;

public class VolumeDisplay : MonoBehaviour {
    void Update()
    {
        display();
    }
    private void display()
    {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerScript = Player.GetComponent<PlayerMovement>();
        Vector3 playerPos = playerScript.transform.localPosition;
        Vector3 volPos = transform.localPosition;
        volPos.x = playerPos.x - 17.2f;
        volPos.y = playerPos.y + 9.4f;
        transform.localPosition = volPos;
    }
}
