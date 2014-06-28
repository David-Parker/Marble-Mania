using UnityEngine;
using System.Collections;

public class SettingsButton : MonoBehaviour {
	public Material low;
	public Material lowS;
	public Material med;
	public Material medS;
	public Material high;
	public Material highS;
	public Material on;
	public Material onS;
	public Material off;
	public Material offS;
	float timer;
	int savedSetting;
	int shadowSetting;
	

	// Use this for initialization
	void Awake () {
		camera.enabled = false;
		savedSetting = PlayerPrefs.GetInt("Quality",0);
		QualitySettings.SetQualityLevel(savedSetting,true);
		if(PlayerPrefs.GetInt("Quality",0) == 0) {
			setLow();
		}
		else if(PlayerPrefs.GetInt("Quality",0) == 3) {
			setMed();
		}
		else if(PlayerPrefs.GetInt("Quality",0) == 5) {
			setHigh();
		}
		
		shadowSetting = PlayerPrefs.GetInt("Shadow",0);
		if(shadowSetting == 0) {
			setOff ();
			GameObject.Find("Saved Constants").GetComponent<Constants>().shadowsEnabled = false;
		}
		else {
			setOn ();
			GameObject.Find("Saved Constants").GetComponent<Constants>().shadowsEnabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(camera.enabled == true) {
			GameObject.Find("play").renderer.enabled = false;
			GameObject.Find("help").renderer.enabled = false;
			GameObject.Find("settings").renderer.enabled = false;
		
		if(Input.GetMouseButtonUp(0) && timer > .25f){
				RaycastHit hit;
				Ray ray = camera.ScreenPointToRay (Input.mousePosition);
					if(Physics.Raycast(ray, out hit)) {
						if(hit.collider.name == "QLow") {
							PlayerPrefs.SetInt("Quality",0);
							QualitySettings.SetQualityLevel(0,true);
							setLow();
						}
						else if(hit.collider.name == "QMed") {
							PlayerPrefs.SetInt("Quality",3);
							QualitySettings.SetQualityLevel(3,true);
							setMed();
						}
						else if(hit.collider.name == "QHigh") {
							PlayerPrefs.SetInt("Quality",5);
							QualitySettings.SetQualityLevel(5,true);
							setHigh();
						}
						else if(hit.collider.name == "SOn") {
							PlayerPrefs.SetInt("Shadow",1);
							GameObject.Find("Saved Constants").GetComponent<Constants>().shadowsEnabled = true;
							setOn();
						}
						else if(hit.collider.name == "SOff") {
							PlayerPrefs.SetInt("Shadow",0);
							GameObject.Find("Saved Constants").GetComponent<Constants>().shadowsEnabled = false;
							setOff ();
						}
						else if(hit.collider.name == "Back") {
							GameObject.Find("play").renderer.enabled = true;
							GameObject.Find("help").renderer.enabled = true;
							GameObject.Find("settings").renderer.enabled = true;
							camera.enabled = false;
							timer = 0;
						}
					}
		}
			timer += Time.deltaTime;
		}
	}
	
	void setLow() {
		GameObject.Find("QLow").renderer.material = lowS;
		GameObject.Find("QMed").renderer.material = med;
		GameObject.Find("QHigh").renderer.material = high;
	}
	void setMed() {
		GameObject.Find("QLow").renderer.material = low;
		GameObject.Find("QMed").renderer.material = medS;
		GameObject.Find("QHigh").renderer.material = high;
	}
	void setHigh() {
		GameObject.Find("QLow").renderer.material = low;
		GameObject.Find("QMed").renderer.material = med;
		GameObject.Find("QHigh").renderer.material = highS;
	}
	void setOff() {
		GameObject.Find("SOn").renderer.material = on;
		GameObject.Find("SOff").renderer.material = offS;		
	}
	void setOn() {
		GameObject.Find("SOn").renderer.material = onS;
		GameObject.Find("SOff").renderer.material = off;
	}
		
}

