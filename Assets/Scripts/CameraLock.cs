using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour {

	// Use this for initialization
	public float radius = 5;
	public Transform target;
	public Vector3 offset;
	public Texture btnLeft;
	public Texture btnRight;
	public float angle;
	

	void Start () {
		if(Application.loadedLevel == 3 || Application.loadedLevel == 9)
			angle = 0;
		else 
			angle = 0;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		angle = target.GetComponent<CameraRotation>().angle;
		Vector3 offset2 = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.up) * offset;
		transform.position = target.position + offset2;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle * Mathf.Rad2Deg, 0);
		
		
	}

}
