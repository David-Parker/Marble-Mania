using UnityEngine;
using System.Collections;

public class onPlat : MonoBehaviour {
	public Vector3 startPos;
	public Vector3 platPos;
	public Vector3 platEndPos;
	public Vector3 change;
	public GameObject ball;
	public bool hasCollided = false;
	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("Marble");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(hasCollided) {
			startPos = ball.transform.position;
			platPos = transform.position;
			change = platEndPos - platPos;
			ball.transform.position = startPos - change;
			platEndPos = platPos;
		}
	}
	
	void OnCollisionEnter(Collision coll) {
		if(coll.gameObject.name == "Marble") {
			hasCollided = true;
			platEndPos = transform.position;
		}
	}
	
	void OnCollisionExit() {
		hasCollided = false;
	}
}
