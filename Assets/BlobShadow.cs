using UnityEngine;
using System.Collections;

public class BlobShadow : MonoBehaviour {
	public Quaternion angle;
	// Use this for initialization
	void Awake() {
		angle = transform.rotation;
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = angle;
	}
}
