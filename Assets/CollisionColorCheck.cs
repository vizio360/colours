using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollisionColorCheck : MonoBehaviour {

	public ParticleSystem ps;
	
	private Color combinedColor;
	private Color originalColor;
	
	void OnTriggerEnter (Collider other) {
		if(other.name == "trigger") {
			Color trigger = other.transform.renderer.material.color;
			originalColor = renderer.material.color;
			IDictionary<Color, Color> d = Colors.colors[trigger];
			combinedColor = originalColor;
			if (!d.ContainsKey(originalColor)) return;
			combinedColor = d[originalColor];
			if(combinedColor == null) return;
			renderer.material.color = combinedColor;
		}
		if(other.name == "target") {
			Color target = other.transform.renderer.material.color;
			if (target != combinedColor)
			{
				ps.Play();
			}
		}
	}

	void OnTriggerExit (Collider other) {
		
		if(other.name == "target") {
			renderer.material.color = originalColor;
			ps.Stop();
		}
	}
	
}
