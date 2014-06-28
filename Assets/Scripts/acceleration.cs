using UnityEngine;
using System.Collections;

public class acceleration : MonoBehaviour {
	public float multiplier = 100;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == "Marble") 
			GameObject.Find ("Marble").GetComponent<Jump>().setforce = multiplier;
	}
	
	void OnCollisionExit(Collision collision) {
		if(collision.gameObject.name == "Marble") 
			GameObject.Find ("Marble").GetComponent<Jump>().setforce = 15;
	}
}
