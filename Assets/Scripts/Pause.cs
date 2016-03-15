using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Escape"))
        {
            Debug.Log("Pause");
            Time.timeScale = 0;
        }
        else if (Input.GetButtonDown("Tab"))
        {
            Debug.Log("Unpause");
            Time.timeScale = 1;
        }
    }
}
