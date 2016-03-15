using UnityEngine;
using System.Collections;

public class ComponentDisable : MonoBehaviour
{
	private TextMesh myMesh;
	private GameObject wrong;
	void Start()
	{
		//		var notThis = FindObjectOfType(typeof(TextMesh));
		//		if (notThis != null)
		//			Debug.Log (notThis + " has been named.");
		//		var notHere = FindObjectOfType (typeof(TextMesh));
		//		if (notHere != null)
		//			Debug.Log (notHere + " is a GameObject.");
		wrong = GameObject.Find ("WrongWay");
		myMesh = wrong.GetComponent<TextMesh> ();
	}
	
	void OnTriggerEnter(Collider other)
	{
		myMesh.gameObject.SetActive (false);
	}
}