using UnityEngine;
using System.Collections;

public class NoJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter() {
		GameObject ball = GameObject.Find ("Marble");
		ball.GetComponent<Jump>().canJump = false;
		ball.GetComponent<Jump>().airforce = 4;
	}
	
	void OnCollisionExit() {
	}
}
