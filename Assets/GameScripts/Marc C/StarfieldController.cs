using UnityEngine;
using System.Collections;

public class StarfieldController : MonoBehaviour {

	ParticleSystem starField;
	const float initialGravitySpeed = 0.2f;

	void Start()
	{
		starField = GetComponent<ParticleSystem>();
	}
	// Update is called once per frame
	void Update () {
	
		starField.gravityModifier = initialGravitySpeed * scroll.speed;
	}
}
