using UnityEngine;
using System.Collections;

public class DirectionalAcceleration : MonoBehaviour {
	public float forward = 1;
	public float side = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter() {
		GameObject.Find("Marble").GetComponent<Jump>().forwardMultiplier = forward;
		GameObject.Find("Marble").GetComponent<Jump>().sideMultiplier = side;
	}
	
	void OnCollisionExit() {
		GameObject.Find("Marble").GetComponent<Jump>().forwardMultiplier = 1;
		GameObject.Find("Marble").GetComponent<Jump>().sideMultiplier = 1;
	}
}
