using System.Collections;
using UnityEngine;

public class LevelScroll : MonoBehaviour {
	float initPos;
	float currPos;
	float change;
	public Camera cam;
	public Bumper1 rightBump;
	public int currLevel = 1;
	float timer;
	float min = -494.9124f; // Really bad hardcoded coordinate value
	float max = 83.08764f;
	int level;
	// Use this for initialization
	
	void Awake() {
		level = PlayerPrefs.GetInt("Level",1);
	}
	void Start () {
		renderer.enabled = false;
		currLevel = 1;
		rightBump = GameObject.Find("rightBump").GetComponent<Bumper1>();
	}
	
	// Update is called once per frame
	void Update () {
		if(renderer.enabled == true) {
			RaycastHit hit;
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
				if(Physics.Raycast(ray, out hit)) {
					if(hit.collider.name == "touchzone" || hit.collider.name == "level1" || hit.collider.name == "level2" || hit.collider.name == "level3"
					|| hit.collider.name == "level4" || hit.collider.name == "level5" || hit.collider.name == "level6" || hit.collider.name == "level7" 
					|| hit.collider.name == "level8" || hit.collider.name == "level9" || hit.collider.name == "level10" || hit.collider.name == "level11" 
					|| hit.collider.name == "level12") {
						if(Input.GetMouseButtonDown(0)) {
							timer = 0;
							initPos = Input.mousePosition.x;
						}
						else if(Input.GetMouseButton(0)) {
							currPos = Input.mousePosition.x;
							change = -(initPos - currPos)/5f;
							Vector3 newPos = new Vector3(transform.localPosition.x + change, transform.localPosition.y,transform.localPosition.z);
						//	Debug.Log(newPos.x);
							if(newPos.x >= max)
								newPos.x = max;
							else if(newPos.x <= min)
								newPos.x = min;
							transform.localPosition = newPos;
							initPos = currPos;
						}
					}
					else if(hit.collider.name == "levelPlay") {
						if(Input.GetMouseButtonDown(0)) {	
							renderer.enabled = false;
							GameObject.Find("Record").renderer.enabled = false;
							GameObject.Find("lvlsel").renderer.enabled = false;
							GameObject.Find("level1").renderer.enabled = false;
							GameObject.Find("restartLevel").renderer.enabled = true;
							cam.enabled = false;
							Application.LoadLevel(currLevel);
						}
					}

					// Level Selection
				if(Input.GetMouseButtonUp(0) && timer <= .15f && change <= 5) {
					for(int i = 1; i <= 12; i++) {
						if(hit.collider.name == ("level" + i) && level >= i){
							audio.Play();
							currLevel = i;
							refreshAll();
							GameObject.Find("level" + i + "HL").renderer.enabled = true;
							GameObject.Find("Record").renderer.enabled = true;
							if(PlayerPrefs.GetFloat("LevelF"+i,9999) != 9999)
								GameObject.Find("Record").GetComponent<TextMesh>().text = "Best Time: " + PlayerPrefs.GetString("LevelS"+i);
							else {
								GameObject.Find("Record").GetComponent<TextMesh>().text = "No Record";
							}
						}
					}
				}
			}
		}
		timer += Time.deltaTime;
	}
	
	void refreshAll() {
		for(int i = 1; i <= 12; i++) {
			GameObject.Find ("level" + i + "HL").renderer.enabled = false;
		}
	}
}