using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldStat : MonoBehaviour {
    public int shieldsCollected;
    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject); //Script is not reset or destroyed when changing scenes
    }

    // Update is called once per frame
    void Update()
    {

    }
}
