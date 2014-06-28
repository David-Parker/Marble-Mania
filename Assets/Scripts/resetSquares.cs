using UnityEngine;
using System.Collections;

public class resetSquares : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == "Marble") {
			GameObject.Find("invistile1").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile2").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile3").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile4").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile5").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile6").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile7").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile8").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile9").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile10").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile11").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile12").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile13").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile14").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile15").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile16").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile17").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile18").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile19").GetComponent<invisOnTouch>().renderer.enabled = false;
			GameObject.Find("invistile20").GetComponent<invisOnTouch>().renderer.enabled = false;
			}
			//Debug.Log ("Colliding");
	}
	
}
