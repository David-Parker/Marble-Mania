using UnityEngine;
using System.Collections;

public class canJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter() {
		GameObject.Find ("Marble").GetComponent<Jump>().canJump = true;
	}
}
