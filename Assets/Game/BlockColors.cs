using UnityEngine;
using System.Collections;

public class BlockColors : MonoBehaviour {
	
	VertexPainter triggerVP;
	VertexPainter targetVP;
	public Color triggerColor;
	public Color targetColor;
 
	public void RandomiseColors(){
		Transform trigger = this.transform.FindChild("trigger");
		Transform target = this.transform.FindChild("target");
		triggerVP = trigger.GetComponent<VertexPainter>();
		targetVP = target.GetComponent<VertexPainter>();
		triggerColor = Colors.getRandomPrimaryColor();	
		targetColor = Colors.getRandomCombinedColorFor(triggerColor);
		triggerVP.changeVertexesColor(triggerColor);
		targetVP.changeVertexesColor(targetColor);
	}

}
