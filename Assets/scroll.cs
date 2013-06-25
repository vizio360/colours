using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 p = this.transform.position;
		Vector3 newP = new Vector3(p.x, 11.0f, p.z);
		this.transform.position = newP;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 p = this.transform.position;
		var y = p.y-0.2f;
		if(y < -11)
		{
			y = 11;
		}
		Vector3 newP = new Vector3(p.x, y, p.z);
		this.transform.position = newP;
	}
}
