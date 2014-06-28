using UnityEngine;
using System.Collections;

public class SkeeBallPortal : MonoBehaviour {
	public int count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(count == 5) {
			transform.position = new Vector3(1189.365f,-61.62268f,488.5794f);
			GameObject.Find ("Skeeball_landing_zone").transform.position = new Vector3(-3000f,-8000f,9999f);
		}
	}
	
}
