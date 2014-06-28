using UnityEngine;
using System.Collections;

public class invisOnTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == "Marble") {
			renderer.enabled = true;
		}
	}
}
