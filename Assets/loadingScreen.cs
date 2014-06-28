using UnityEngine;
using System.Collections;

public class loadingScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.isLoadingLevel)
			camera.enabled = true;	
	}
	void OnLevelWasLoaded() {
		camera.enabled = false;	
	}
}
