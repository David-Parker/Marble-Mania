using UnityEngine;
using System.Collections;
using System.Reflection;


public class Jump : MonoBehaviour {

	// Use this for initialization
	public bool canJump = true;
	public int level = 0;
	public float angle;
	public float setforce = 10;
	public float force = 10;
	public float jumpForce = 18;
	public float airforce = 7;
	public float initAF;
	public float forwardMultiplier = 1;
	public float sideMultiplier = 1;
	public Texture btnUp;
	public Texture btnDown;
	public Texture btnLeft;
	public Texture btnRight;
	public Texture btnJump;
	public JoystickC joystick;
	int numCols;
	void Start () {
		initAF = airforce;
		//Screen.showCursor = false;
	}
	
	void Awake() {
		level++;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(isInAir())
			force = airforce;
		else force = setforce;
		
		float angle = GetComponent<CameraRotation>().angle;
		Vector3 forward = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
		Vector3 back = -forward;
		Vector3 left = new Vector3(-Mathf.Cos(angle), 0, Mathf.Sin(angle));
		Vector3 right = -left;
		
		rigidbody.AddForce (forward * force * joystick.position.y * forwardMultiplier); 
		rigidbody.AddForce (right * force * joystick.position.x * sideMultiplier); 
		
		Debug.DrawRay(transform.position, forward);
		
		if(Application.isLoadingLevel) {
			transform.position = new Vector3(0,0,0);
		}
		
		if(Input.GetKeyDown(KeyCode.Space) && canJump) {
			jump();
		}
		if(Input.GetKey(KeyCode.W)) {
			rigidbody.AddForce (forward * force * forwardMultiplier);
			//rigidbody.AddForce (Vector3.down * 2);
		}
			//rigidbody.AddForce (Vector3.down * 2);
		if(Input.GetKey(KeyCode.S )) {
			rigidbody.AddForce (back * force * forwardMultiplier);
		}
		if(Input.GetKey(KeyCode.A)) {
			rigidbody.AddForce (left * force * sideMultiplier);
		
		}
		if(Input.GetKey(KeyCode.D)) {
			rigidbody.AddForce (right * force * sideMultiplier);
		}
		if(Input.GetKey(KeyCode.Escape)) {
			GameObject.Find("alert").renderer.enabled = true;
		}
	}
	
	void OnLevelWasLoaded(int lvl) {
		airforce = initAF;
		numCols = 0;
		rigidbody.velocity = Vector3.zero;
		rigidbody.angularVelocity = Vector3.zero;
		setPos();
	}
	
	public void jump() {
		rigidbody.AddForce (Vector3.up * jumpForce* .7f,ForceMode.Impulse);
		//rigidbody.AddForce (Vector3.up * jumpForce*70);
		AudioSource.PlayClipAtPoint(GameObject.Find ("JumpSound").audio.clip,transform.position);
		canJump = false;
	}
	void OnCollisionEnter() {
		numCols++;
	}
	void OnCollisionExit() {
		numCols--;
	}
	
	public bool isInAir() {
		return numCols == 0;
	}
	
	public void setPos() {
		Vector3 startLocation = GameObject.Find ("restart").transform.position;
			Quaternion startRotation = GameObject.Find ("restart").transform.rotation;
			transform.position = startLocation;
			transform.rotation = startRotation;
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
	}
		
}
