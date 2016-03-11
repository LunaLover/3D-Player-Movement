using UnityEngine;
using System.Collections;

public class Unpause : MonoBehaviour {

	void UnPause()
    {
        if (Input.GetKeyDown("P"))

        {
            Debug.Log("P is pressed");
            Screen.lockCursor = true;
            Time.timeScale = 1;
        }
	}


}
