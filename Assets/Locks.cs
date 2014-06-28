using UnityEngine;
using System.Collections;

public class Locks : MonoBehaviour {
	int level;

	// Use this for initialization
	void Start () {
		level = PlayerPrefs.GetInt("Level",1);
		for(int i = 2; i <= level; i++) {
			GameObject.Find("level" + i + "Lock").renderer.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
