using UnityEngine;
using System.Collections;

public class Bumper1 : MonoBehaviour {
	public bool isBumping;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider coll) {
		if(coll.gameObject.name == "SideLeft") {
			isBumping = true;
			//Debug.Log("Collided");
		}
	}
	void OnTriggerExit(Collider coll) {
		isBumping = false;
	}
}
