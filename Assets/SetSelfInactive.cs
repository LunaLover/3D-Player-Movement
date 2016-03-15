using UnityEngine;
using System.Collections;

public class SetSelfInactive : MonoBehaviour {
	private GameObject wrong;
	private TextMesh myMesh;
	// Use this for initialization
	void Update () {
		wrong = GameObject.Find ("WrongWay");
		myMesh = wrong.GetComponent<TextMesh> ();
		if (Time.frameCount == 1.1) {
			print("Alarms are sounding. It's time");
			myMesh.gameObject.SetActive (false);
		}
	}
}
