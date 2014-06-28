using UnityEngine;
using System.Collections;

public class SkeeBallHole : MonoBehaviour {
	public bool hasLanded = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(){
		if(hasLanded == false) {
			GameObject.Find ("portal").GetComponent<SkeeBallPortal>().count++; 
		}
		hasLanded = true;
	}
}
