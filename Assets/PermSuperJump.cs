using UnityEngine;
using System.Collections;

public class PermSuperJump : MonoBehaviour {
	public float multiplier;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter() {
		GameObject.Find ("Marble").GetComponent<Jump>().jumpForce = multiplier;
	}
}
