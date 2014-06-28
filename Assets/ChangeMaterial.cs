using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {
	public bool hasLanded = false;
	public Material mymat;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(){
		if(hasLanded == false) {
			renderer.material = mymat;
		}
		hasLanded = true;
	}
}
