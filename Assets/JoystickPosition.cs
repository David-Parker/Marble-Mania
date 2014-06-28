using UnityEngine;
using System.Collections;

public class JoystickPosition : MonoBehaviour {
	public bool isCross = false;
	// Use this for initialization
	void Awake () {
		if(Screen.dpi > 0) {
			if(!isCross)
				guiTexture.pixelInset = new Rect(Screen.width/10.5f,Screen.height/9,Screen.dpi*.6f,Screen.dpi*.6f);
			else {
				guiTexture.pixelInset = new Rect((Screen.width/10.5f)-(Screen.dpi*.6f/4),(Screen.height/9)-(Screen.dpi*.6f/4),Screen.dpi*.9f,Screen.dpi*.9f);
			}
		}
		else {
			guiTexture.pixelInset = new Rect(Screen.width/10.5f,Screen.height/9,Screen.width/8.5f,Screen.width/8.5f);	
		}
		
	}
}
