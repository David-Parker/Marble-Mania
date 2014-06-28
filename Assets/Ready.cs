using UnityEngine;
using System.Collections;

public class Ready : MonoBehaviour {
	public bool start = false;
	float time;

	// Use this for initialization
	void Start () {
		GameObject.Find("Ready").GetComponent<TextMesh>().renderer.enabled = false;
		GameObject.Find("Set").GetComponent<TextMesh>().renderer.enabled = false;
		GameObject.Find("Go").GetComponent<TextMesh>().renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(start) {
			Screen.showCursor = false;
			GameObject.Find("Marble").GetComponent<Jump>().enabled = false;
			time+=Time.deltaTime;
			if(time <= 1.0f) {
				GameObject.Find("Ready").GetComponent<TextMesh>().renderer.enabled = true;
			}
			else if(time > 1.0f && time < 2.6f) {
				GameObject.Find("Ready").GetComponent<TextMesh>().renderer.enabled = false;
				GameObject.Find("Set").GetComponent<TextMesh>().renderer.enabled = true;
			}
		
			else if(time >= 2.6f && time < 3.0f) {
				if(!audio.isPlaying)
					audio.Play();
				GameObject.Find("Ready").GetComponent<TextMesh>().renderer.enabled = false;
				GameObject.Find("Set").GetComponent<TextMesh>().renderer.enabled = false;
				GameObject.Find("Go").GetComponent<TextMesh>().renderer.enabled = true;
			}
			if(time >= 3.0f) {
				GameObject.Find ("Timer").GetComponent<Timer>().ready = true;
				GameObject.Find ("Timer").GetComponent<Timer>().time = 0;
				GameObject.Find("Go").GetComponent<TextMesh>().renderer.enabled = false;
				GameObject.Find("Marble").GetComponent<Jump>().enabled = true;
				start = false;
				camera.enabled = false;
			}
		}
	}
	
	void OnLevelWasLoaded() {
		if(Application.loadedLevel > 0) {
			camera.enabled = true;
			start = true;
			time = 0;
		}
	}
}
