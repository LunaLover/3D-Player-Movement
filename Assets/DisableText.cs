using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class DisableText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		TextMesh mesh = (TextMesh)FindObjectOfType (typeof(TextMesh));
			if (mesh)
				Debug.Log ("Found the Mesh: " + mesh.name);
			else
				Debug.Log ("Didn't find it.");
		mesh.gameObject.SetActive(false);
		}
	}