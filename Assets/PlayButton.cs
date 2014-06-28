using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {
	public Vector3 rayPos;
	public Material mute;
	public Material muted;
	public GameObject trgt;
	public bool Muted;
	public Camera cam;
	public Camera LevelCam;
	public Camera SettingsCam;
	public Camera HelpCam;
	public LevelScroll levelscroll;
	// Use this for initialization
	void Start () {
		if(Application.loadedLevel == 0) {
			LevelCam.enabled = false;
			GameObject.Find("play").renderer.enabled = true;
			GameObject.Find("help").renderer.enabled = true;
			GameObject.Find("settings").renderer.enabled = true;
			GameObject.Find("lvlsel").renderer.enabled = false;
			GameObject.Find("restartAlert").renderer.enabled = false;
		}
		GameObject.Find("alert").renderer.enabled = false;
	}
	// Update is called once per frame
	void LateUpdate () {
		if(Input.GetMouseButtonDown(0)){
				RaycastHit hit;
				Ray ray = cam.ScreenPointToRay (Input.mousePosition);
					if (Physics.Raycast(ray, out hit)) { 
						if (hit.collider.name == "play" && GameObject.Find("play").renderer.enabled == true) {
							audio.Play();
							GameObject.Find("play").renderer.enabled = false;
							GameObject.Find("help").renderer.enabled = false;
							GameObject.Find("settings").renderer.enabled = false;
							GameObject.Find("lvlsel").renderer.enabled = true;
							GameObject.Find("levels").renderer.enabled = true;
							LevelCam.enabled = true;
							//Application.LoadLevel(Application.loadedLevel + 1);
						}
						else if (hit.collider.name == "mute") {
							if(Muted){
								trgt.renderer.material = mute;
								Muted = false;
								AudioListener.pause = false;
							}
							else {
								trgt.renderer.material = muted;
								Muted = true;
								AudioListener.pause = true;
							}
						}
				
						else if (hit.collider.name == "restartLevel" && Application.loadedLevel > 0) {
							GameObject.Find("restartAlert").renderer.enabled = true;
						}
						else if (hit.collider.name == "restartYes" && GameObject.Find("restartAlert").renderer.enabled == true) {
							GameObject.Find("restartAlert").renderer.enabled = false;
							Application.LoadLevel(Application.loadedLevel);
						}
						else if (hit.collider.name == "restartNo" && GameObject.Find("restartAlert").renderer.enabled == true) {
							GameObject.Find("restartAlert").renderer.enabled = false;
						}
				
						else if((hit.collider.name == "home" || Input.GetKey(KeyCode.Escape)) && Application.loadedLevel > 0 )
							GameObject.Find("alert").renderer.enabled = true;
					
						else if(hit.collider.name == "alertNo" && GameObject.Find("alert").renderer.enabled == true)
							GameObject.Find("alert").renderer.enabled = false;
					
						else if(hit.collider.name == "alertYes" && GameObject.Find("alert").renderer.enabled == true) {
							GameObject.Find("alert").renderer.enabled = false;	
							GameObject[] myGameObjs = FindObjectsOfType(typeof(GameObject)) as GameObject[];
								foreach(GameObject obj in myGameObjs) {
									Destroy(obj);
								}
							Application.LoadLevel(0);
						}
				
						else if(hit.collider.name == "settings" && GameObject.Find("settings").renderer.enabled == true) {
							audio.Play();
							SettingsCam.enabled = true;
							//QualitySettings.currentLevel=QualityLevel.Fastest;
						}
				
						else if(hit.collider.name == "help" && GameObject.Find("help").renderer.enabled == true) {
							audio.Play();
							HelpCam.enabled = true;
						}
						else if(hit.collider.name == "NewGame" && GameObject.Find("play").renderer.enabled == true) {
							PlayerPrefs.SetInt("Level",1);
						}
					}
		}
	}
}
