using UnityEngine;
using System.Collections;

public class PermaSuperJumpRemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter() {
		GameObject.Find ("Marble").GetComponent<Jump>().jumpForce = 18;
	}
}
