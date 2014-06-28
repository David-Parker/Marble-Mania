using UnityEngine;
using System.Collections;

public class StartAnimationOnCollision : MonoBehaviour {
	bool hasTouched = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter() {
		if(!hasTouched) {
			animation.Play();
			hasTouched = true;
		}
	}
}
