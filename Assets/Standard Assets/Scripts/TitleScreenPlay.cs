using UnityEngine;
using System.Collections;

public class TitleScreenPlay : MonoBehaviour {

	public void Play()
    {
        Application.LoadLevel(1); //Loads the listed level, change the number to scene needed
    }
}
