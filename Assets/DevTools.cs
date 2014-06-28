using UnityEngine;
using System.Collections;

public class DevTools : MonoBehaviour {
	public int level = 1;
	public Texture btnRight;
	public Texture btnLeft;
	public Jump ball;
	// Use this for initialization
	void Start () {
	
	}
	
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetKey(KeyCode.RightArrow)) {
//			Application.LoadLevel(Application.loadedLevel + 1);
//		}
//		else if(Input.GetKey(KeyCode.LeftArrow) && Application.loadedLevel > 0) {
//			Application.LoadLevel(Application.loadedLevel - 1);
//		}
		if(Input.GetKey(KeyCode.X)) {
			if(Screen.showCursor == false)
				Screen.showCursor = true;
			else if(Screen.showCursor == true)
				Screen.showCursor = false;
		}
	}
	
	/*void OnGUI() {
		 if (GUI.Button(new Rect(75, 25, 50, 50), btnRight))
            Application.LoadLevel(Application.loadedLevel + 1);
		
		else if (GUI.Button(new Rect(25, 25, 50, 50), btnLeft) && Application.loadedLevel > 0)
            Application.LoadLevel(Application.loadedLevel - 1);
	}*/
	
	void OnLevelWasLoaded() {
		ball.setforce = 15;
		ball.force = 15;
		ball.jumpForce = 18;
		
	}
}
