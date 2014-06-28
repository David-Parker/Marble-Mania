using UnityEngine;
using System.Collections;

public class ToLevelX : MonoBehaviour {

	// Use this for initialization
	public int levelNum = 0;
	GameObject marble;
	public Camera main;
	public Camera end;
	void Start () {
		marble = GameObject.Find("Marble");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == "Marble")
			if(PlayerPrefs.GetInt("Level") <= Application.loadedLevel)
				PlayerPrefs.SetInt("Level",Application.loadedLevel + 1);
			
			marble.rigidbody.velocity = Vector3.zero;
			marble.rigidbody.angularVelocity = Vector3.zero;
			marble.GetComponent<Jump>().enabled = false;
			marble.GetComponent<CameraRotation>().enabled = false;
			marble.renderer.enabled = false;
			audio.Play ();
			main.enabled = false;
			end.enabled = true;
			GameObject.Find ("Win Camera").GetComponent<Camera>().enabled = true;
		//	Application.LoadLevel(Application.loadedLevel + 1);
		
	}
}
