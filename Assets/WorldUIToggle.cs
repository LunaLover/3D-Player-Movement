using UnityEngine;
using System.Collections;

public class WorldUIToggle : MonoBehaviour {
	public GameObject Toggler;
	public GUIText Text;
	// Use this for initialization
	void Start () {
		print (this.gameObject.name);
		Toggler = this.gameObject;
	}
	void update(){
		if (Toggler.name == "First")
			Text.name = FindObjectsOfType<GUIText;
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if (Toggler.name == "First")
			print (Toggler.name + " toggler passed");

	}
}
