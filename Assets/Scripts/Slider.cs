using UnityEngine;
using System.Collections;

public class Slider : MonoBehaviour {

    public float vSliderValue = 0.0F;
    public void VolumeControl(float volume)
    {
        AudioListener.volume = volume;
    }
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
