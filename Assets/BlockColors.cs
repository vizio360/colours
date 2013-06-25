using UnityEngine;
using System.Collections;

public class BlockColors : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void RandomiseColors(){
		Color trigger = Colors.getRandomPrimaryColor();	
		Color target = Colors.getRandomCombinedColorFor(trigger);
		this.transform.FindChild("target").renderer.material.color = target;
		this.transform.FindChild("trigger").renderer.material.color = trigger;
	}
}
