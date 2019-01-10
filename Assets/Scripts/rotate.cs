using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    void Update()
    {
        transform.Rotate(0, 0, 60 * Time.deltaTime); //rotates 60 degrees per second around z axis
    }

}
