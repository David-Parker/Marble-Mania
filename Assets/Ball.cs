using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
public Material def;
public Material cue;
public Material beach;

	// Use this for initialization
	void OnLevelWasLoaded () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("Skin",1) == 1)
			GameObject.Find("Marble").renderer.material = def;
		else if(PlayerPrefs.GetInt("Skin",1) == 2)
			GameObject.Find("Marble").renderer.material = cue;
		else if(PlayerPrefs.GetInt("Skin",1) == 3)
			GameObject.Find("Marble").renderer.material = beach;
	}
}
