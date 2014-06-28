using UnityEngine;
using System.Collections;

public class Constants : MonoBehaviour {
	public bool shadowsEnabled = false;

	// Use this for initialization
	void Start () {
	
	}
	
	 void OnLevelWasLoaded(int level) {
		if(shadowsEnabled == true) {
			GameObject.Find("Blob Shadow Projector").GetComponent<Projector>().enabled = true;
		}
	}
}
