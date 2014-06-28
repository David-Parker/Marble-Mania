using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {
	bool canPlay;
	public float angle;
	public bool custom;
	public 

	// Use this for initialization
	void Start () {
		canPlay = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter() {
		GameObject.Find ("restart").transform.position = new Vector3(transform.position.x,transform.position.y + 5, transform.position.z);
		if(custom)
			GameObject.Find ("Marble").GetComponent<Jump>().angle = angle;
		if(canPlay){
			audio.Play();
			canPlay = false;
		}
	}
}
