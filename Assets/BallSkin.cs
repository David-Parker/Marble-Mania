using UnityEngine;
using System.Collections;

public class BallSkin : MonoBehaviour {
public Material myMat;
public bool hasSkin2 = false;
public int num = 1;

	// Use this for initialization
	void Start () {
	}
	void OnCollisionEnter() {
		audio.Play();
		GameObject.Find("Marble").renderer.material = myMat;
		PlayerPrefs.SetInt("Skin",num);
	}
}