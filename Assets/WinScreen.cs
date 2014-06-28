using UnityEngine;
using System.Collections;

public class WinScreen : MonoBehaviour {
public Camera load;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnLevelWasLoaded() {
		camera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(camera.enabled) {
			Screen.showCursor = true;
			GameObject.Find("Single Joystick").guiTexture.enabled = false;
			GameObject.Find("Back").guiTexture.enabled = false;
			if(Input.GetMouseButtonUp(0)) {
				RaycastHit hit;
				Ray ray = camera.ScreenPointToRay (Input.mousePosition);
					if(Physics.Raycast(ray, out hit)) {
						if(hit.collider.name == "Replay") {
							Application.LoadLevel(Application.loadedLevel);
						}
						else if(hit.collider.name == "Continue")
							Application.LoadLevel(Application.loadedLevel + 1);
							load.enabled = true;
					}
			}
		}
	}
}
