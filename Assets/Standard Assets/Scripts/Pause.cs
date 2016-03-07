using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	void FixedUpdate ()
    {
	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Screen.lockCursor = false;
            Time.timeScale = 0;
        }
	}


//	void Unpause ()
//	{
//        if (Time.timeScale = 0f && Input.GetKeyDown(KeyCode.Escape))
//        {
//
//        }
//}
}