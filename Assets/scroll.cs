using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Init();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 p = this.transform.position;
		var y = p.y - 0.1f;
		if(y < -11)
		{
			Init ();
		}
		else
		{
			updatePosition(y);
		}
	}
	
	void Init() {
		BlockColors b = GetComponent<BlockColors>();
		b.RandomiseColors();
		updatePosition(11.0f);
	}
	
	void updatePosition(float y) {
		Vector3 p = this.transform.position;
		Vector3 newP = new Vector3(p.x, y, p.z);
		this.transform.position = newP;
	}
}
