using UnityEngine;
using System.Collections;

public class CheckpointAdvanced : MonoBehaviour {
	bool hasTouched = false;
	bool canPlay;
	public bool custom;
	public float angle;
	// Use this for initialization
	void Start () {
		canPlay = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(hasTouched) {
			GameObject.Find ("restart").transform.position = new Vector3(transform.position.x,transform.position.y + 5, transform.position.z);
			if(custom)
				GameObject.Find ("Marble").GetComponent<Jump>().angle = angle;
		}
	}
	
	void OnCollisionEnter() {
		hasTouched = true;
		if(canPlay){
			audio.Play();
			canPlay = false;
		}
	}
}
