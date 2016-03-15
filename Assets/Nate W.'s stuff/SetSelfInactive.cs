using UnityEngine;
using System.Collections;

public class SetSelfInactive : MonoBehaviour {
	private GameObject wrong;
	private TextMesh myMesh;
	// Use this for initialization
	void Update () {
		wrong = GameObject.Find ("WrongWay");
		myMesh = wrong.GetComponent<TextMesh> ();
		if (Time.frameCount == 5) {
			myMesh.gameObject.SetActive (false);
			print("Alarms are sounding. It's time");

		}
	}
}
