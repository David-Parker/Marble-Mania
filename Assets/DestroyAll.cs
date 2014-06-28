using UnityEngine;
using System.Collections;

public class DestroyAll : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	void Awake() {
		GameObject[] myGameObjs = FindObjectsOfType(typeof(GameObject)) as GameObject[];
		for(int i = 0; i < myGameObjs.Length;i++) {
			Destroy(myGameObjs[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
