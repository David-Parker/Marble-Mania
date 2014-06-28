using UnityEngine;
using System.Collections;

public class toHome : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter() {
		GameObject[] myGameObjs = FindObjectsOfType(typeof(GameObject)) as GameObject[];
			foreach(GameObject obj in myGameObjs) {
				Destroy(obj);
			}
		Application.LoadLevel(0);
	}
}
