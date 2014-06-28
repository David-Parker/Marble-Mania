using UnityEngine;
using System.Collections;

public class resetToStart : MonoBehaviour {
	public float angle;
	void Start () {
		GameObject.Find ("Marble").GetComponent<Jump>().angle = GameObject.Find ("Marble").GetComponent<CameraRotation>().angle;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == "Marble") {
			GameObject.Find("Marble").GetComponent<Jump>().setPos();
			GameObject.Find ("Marble").GetComponent<CameraRotation>().angle = GameObject.Find ("Marble").GetComponent<Jump>().angle;
			if(Application.loadedLevel > 0)
				GameObject.Find ("Reset Sound").audio.Play ();
			}
			//Debug.Log ("Colliding");
	}
}
