using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollisionColorCheck : MonoBehaviour {

	public ParticleSystem ps;
	
	public bool colliding = false;
	
	private VertexPainter vp;
	
	private Color combinedColor;
	private Color _prevColor;
	private Color _currentColor;
	public Color currentColor
	{
		get { return _currentColor; }
		set { 
			_currentColor = value;
			vp.changeVertexesColor(_currentColor);
		}
	}
		
	void Start () {
		Transform t = this.transform.FindChild("shipTriangle");
		vp = t.GetComponent<VertexPainter>();
		currentColor = Colors.getRandomPrimaryColor();
	}
		
	void OnTriggerEnter (Collider other) {
		if(other.name == "trigger") {
			colliding = true;
			
			Color trigger = other.transform.parent.GetComponent<BlockColors>().triggerColor;
			
			IDictionary<Color, Color> d = Colors.colors[trigger];
			_prevColor = currentColor;
			combinedColor = currentColor;
			if (!d.ContainsKey(currentColor)) return;
			combinedColor = d[currentColor];
			currentColor = combinedColor;
		}
		if(other.name == "target") {
			Color target = other.transform.parent.GetComponent<BlockColors>().targetColor;
			if (target != combinedColor)
			{
				ps.Play();
				scroll.speed -= 0.5f;
			}
			else{
				scroll.speed += 0.5f;	
			}
		}
	}

	void OnTriggerExit (Collider other) {
		if(other.name == "target") {
			currentColor = _prevColor;
			ps.Stop();
			colliding = false;
		}
	}
	
}
