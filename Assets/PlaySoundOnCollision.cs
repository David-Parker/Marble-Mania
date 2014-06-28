using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlaySoundOnCollision : MonoBehaviour {
	public bool isColliding = false;
	public float timeOff;
	// Use this for initialization
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!isColliding)
			timeOff+=Time.deltaTime;
		audio.volume = GameObject.Find ("Marble").GetComponent<Velocity>().speed * 3.5f;
		// Delay buffer for switch off of the rolling sound for smoothness
		if(timeOff >=.2f && audio.isPlaying) {
			audio.Stop();
		}
	}
	
	void OnCollisionEnter() {
		timeOff = 0;
		isColliding = true;
		if(!audio.isPlaying) {
			audio.Play ();
		}
	}
	
	void OnCollisionExit() {
		isColliding = false;
		timeOff = 0;
	}
	
}
