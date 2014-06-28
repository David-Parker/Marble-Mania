using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float time;
	public Camera cam;
	public bool ready = false;
	float min;
	int sec;
	float mil;
	public string display;
	
	// Use this for initialization
	void Start () {
		display = 00+":"+00+":"+00;
		//PlayerPrefs.DeleteAll();
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.loadedLevel > 0 && !cam.enabled && ready) {
			guiText.enabled = true;
			time += Time.deltaTime;
		//	time = Mathf.Round(time * 100f) / 100f;
			sec = (int) time%60;
			mil = (Mathf.Round(time%1 * 10f) / 10f) * 10;
			min = Mathf.Floor(time / 60);
			display = min.ToString("00") + ":" + sec.ToString("00") + ":" + mil%10;
			guiText.text = display;
		}
		else if(cam.enabled) {
			guiText.enabled = false;
			GameObject.Find("levelTime").GetComponent<TextMesh>().text = GameObject.Find("Timer").GetComponent<Timer>().display;
			if(time < PlayerPrefs.GetFloat("LevelF" + Application.loadedLevel,9999.0f)) {
				GameObject.Find("newRecord").renderer.enabled = true;
				PlayerPrefs.SetFloat("LevelF" + Application.loadedLevel,time);
				PlayerPrefs.SetString("LevelS" + Application.loadedLevel,display);
			}
			GameObject.Find("bestTime").GetComponent<TextMesh>().text = PlayerPrefs.GetString("LevelS" + Application.loadedLevel,"");
		}
	}
	
	void OnLevelWasLoaded() {
		GameObject.Find("newRecord").renderer.enabled = false;
		ready = false;
		time = 0;
		GameObject.Find("Timer").guiText.text = "00:00:0";
	}
}
