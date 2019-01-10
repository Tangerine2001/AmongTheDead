using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCover : MonoBehaviour {
    private MeshRenderer cover;
	// Use this for initialization
	void Start () {
        cover = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        checkBossAlive();
	}
    public void checkBossAlive() //The health bar doesn't fully go down, so when it does, this black box will appear and act as the health bar
    {
        GameObject Boss = GameObject.Find("ZombieBoss");
        BossController bossScript = Boss.GetComponent<BossController>();
        if(bossScript.bossAnim.GetBool("alive"))
        {
            cover.enabled = false;
        }
        if (!bossScript.bossAnim.GetBool("alive"))
        {
            cover.enabled = true;
        }
    }
}
