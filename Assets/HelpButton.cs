using UnityEngine;
using System.Collections;

public class HelpButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(camera.enabled) {
			GameObject.Find("play").renderer.enabled = false;
			GameObject.Find("help").renderer.enabled = false;
			GameObject.Find("settings").renderer.enabled = false;
			
			if(Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = camera.ScreenPointToRay (Input.mousePosition);
				if(Physics.Raycast(ray, out hit)) {
					if(hit.collider.name == "helpBack") {
						GameObject.Find("play").renderer.enabled = true;
						GameObject.Find("help").renderer.enabled = true;
						GameObject.Find("settings").renderer.enabled = true;
						camera.enabled = false;
					}
				}
			}
		}
	}
}
