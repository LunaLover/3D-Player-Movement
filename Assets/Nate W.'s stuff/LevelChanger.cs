using UnityEngine;
using System.Collections;

public class LevelChanger: MonoBehaviour {
	
	public void OnTriggerEnter(Collider other)
	{
		Application.LoadLevel(0); //Attack to the 1st button the one with "Start" as its text.
	}
}
