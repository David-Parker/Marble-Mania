using UnityEngine;
using System.Collections;

public class superJump : MonoBehaviour {

	// Use this for initialization
	public float multiplier = 10;
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == "Marble") {
			GameObject.Find ("Marble").GetComponent<Jump>().jumpForce = multiplier;
		}
	}
	
	void OnCollisionExit(Collision collision) {
		if(collision.gameObject.name == "Marble") {
			GameObject.Find ("Marble").GetComponent<Jump>().jumpForce = 18;
		}
	}
			
}
