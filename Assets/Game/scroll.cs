using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {
	
	public static float speed = 5.0f;
	
	private BlockColors block;
	// Use this for initialization
	void Start () {
		block = GetComponent<BlockColors>();
		Init();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 p = this.transform.position;
		if(p.y < -11.0f)
		{
			Init();
		}
		else
		{
			updatePosition(scroll.speed);
		}
	}
	
	void Init() {
		block.RandomiseColors();
		Vector3 p = this.transform.position;
		Vector3 newP = new Vector3(p.x, 11.0f, p.z);
		this.transform.position = newP;
	}
	
	void updatePosition(float delta) {
		Vector3 newP = new Vector3(0.0f, -delta * Time.deltaTime, 0.0f);
		this.transform.Translate(newP);
	}
}
