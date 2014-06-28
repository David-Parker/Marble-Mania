using UnityEngine;
using System.Collections;

public class ToCoordinate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter() {
		GameObject.Find("Marble").transform.position = new Vector3(167.7844f,70,0);
		GameObject.Find("Marble").rigidbody.velocity = Vector3.zero;
		GameObject.Find("Marble").rigidbody.angularVelocity = Vector3.zero;
		
	}
}
