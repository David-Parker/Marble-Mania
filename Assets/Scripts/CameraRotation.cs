using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
	public float revolutions = 1;
	public bool isMobileMode;
	public JoystickC joystick;
	public float change;
	Vector2 initPos;
	Vector2 lastPos;
	public Jump jcom;
	bool jumpEnabled;
	float time;
	float tempTime;
	Vector2 currPos;
	int fingerId = -1;
	
	[HideInInspector]
	public float angle;
		
	// Use this for initialization
	void Start () {
		if(Application.loadedLevel == 3 || Application.loadedLevel == 9 || Application.loadedLevel == 8)
			angle = 300;
		else if(Application.loadedLevel == 6)
			angle = 89.55f;
		else if(Application.loadedLevel == 10)
			angle  = -2.4f;
		else if(Application.loadedLevel == 11)
			angle  = .258f;
	}
	
	// Update is called once per frame
	void Update () {
		if(!isMobileMode) {
			float ang = (Input.mousePosition.x / (Screen.width-1)) - 0.5f;		// Ang in range [-0.5, 0.5]
			angle = ang * revolutions * Mathf.PI / 0.5f;		// angle in range revolutions * [-Pi, Pi]
		}
		else {
			foreach (Touch touch in Input.touches) {
				if (touch.fingerId != joystick.lastFingerId) {
					if (touch.phase == TouchPhase.Began) {
						time = 0;
						fingerId = touch.fingerId;
						initPos = lastPos = touch.position;
					 }
					 else if ((Input.GetMouseButtonUp(touch.fingerId)) || touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled) {
						if(jcom.canJump && time <= .28f && ((currPos - initPos).magnitude < 15)) 
							jcom.jump ();
						
						fingerId = -1;
						time = 0;
					}

					if (touch.fingerId == fingerId) {	
						currPos = touch.position;
						change = currPos.x - lastPos.x;
						angle += change * Mathf.PI / (Screen.width/2.5f);
				   	    lastPos = currPos;				
					}
					time+=Time.deltaTime;
				}	
			}
		}
	}
}
	
	
	

