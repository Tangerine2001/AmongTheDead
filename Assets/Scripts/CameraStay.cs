using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStay : MonoBehaviour {
    private Rigidbody2D camera;
    private Transform player;

    public bool isFollowing;
    [SerializeField] //Provides a variable that can be changed in Unity IDE for testing purposes
    private float xMin = -19;
    [SerializeField]
    private float yMin = 12;
    [SerializeField]
    private float xMax = 310;
    [SerializeField]
    private float yMax = 42.8f;

    public float xOffset;
    public float yOffset;
    void Start()
    {
        player = GameObject.Find("Player").transform;
        isFollowing = true;
    }
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, xMin, xMax), Mathf.Clamp(player.position.y, yMin, yMax), -10);
        //The camera doesn't move past the coordinates that are set in the Unity IDE
    }
}
