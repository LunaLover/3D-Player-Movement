using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    void Update()
    {
<<<<<<< HEAD
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
=======
        bool pressed = false;

        if (Input.GetButtonDown("Escape") && (pressed == false))
        {
            Debug.Log("Pause");
            Time.timeScale = 0;
            pressed = true;
            if (pressed == true)
            {
                
            }
        }

        if (Input.GetButtonDown("Escape") && (pressed == true))
        {
            Debug.Log("Unpause");
            Time.timeScale = 1;
            pressed = false;
        }

    }

>>>>>>> refs/remotes/origin/master
}
