using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNavagation : MonoBehaviour
{
    int index = 0;
    [SerializeField]
    public int totalLevels = 4;
    [SerializeField]
    public float yOffset = 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (index < totalLevels - 1)
            {
                index++;
                Vector2 position = transform.position;
                position.y -= yOffset;
                transform.position = position;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (index > 0)
            {
                index--;
                Vector2 position = transform.position;
                position.y += yOffset;
                transform.position = position;
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (index == 0)
            {
                SceneManager.LoadScene("Tutorial + Tutorial");
            }
            if (index == 1)
            {
                SceneManager.LoadScene("Level 1");
            }
            if (index == 2)
            {
                SceneManager.LoadScene("Level 2");
            }
            if (index == 3)
            {
                SceneManager.LoadScene("Level 3");
            }
        }
    }

}




	