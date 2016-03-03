using UnityEngine;
using System.Collections;

public class Unpause : MonoBehaviour {

	void OnClick()
    {
            Debug.Log("P is pressed");
            Screen.lockCursor = true;
            Time.timeScale = 1;
	}


}
