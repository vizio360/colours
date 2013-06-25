using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool esc = Input.GetKeyDown(KeyCode.Escape);
		if (esc) { 
			Application.Quit(); 
		}
		bool left = Input.GetKey(KeyCode.LeftArrow);
		bool right = Input.GetKey(KeyCode.RightArrow);
		float x = 0.0f;
		if (left) x = 1.0f;
		if (right) x = -1.0f;
		if (x == 0.0f) return;
		x *= Time.deltaTime;
		transform.Translate(x * speed, 0.0f, 0.0f);
	}
}
