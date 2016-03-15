using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject pause;

    void Update()
    {
        if (Input.GetButtonDown("Escape"))
        {
            pause.SetActive(true);
            Debug.Log("Pause");
            Time.timeScale = 0;
        }
        else if (Input.GetButtonDown("Tab"))
        {
            pause.SetActive(false);
            Debug.Log("Unpause");
            Time.timeScale = 1;
        }
    }
}
