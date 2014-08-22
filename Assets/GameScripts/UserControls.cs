using UnityEngine;
using System.Collections;

public class UserControls : MonoBehaviour {
	
	private GUIStyle customButton;
	private int buttonsHeight = 90;
	
	private GameObject spaceShip;
	private CollisionColorCheck checker;
	// Use this for initialization
	void Start () {
		spaceShip = GameObject.Find("Spaceship");
		checker = spaceShip.GetComponent<CollisionColorCheck>();
		customButton = new GUIStyle();
	}
	
	private bool CreateButton(Color color) {
		var t = new Texture2D(1, 1);
		t.SetPixel(0, 0, color);
		t.Apply();
		customButton.normal.background = t;
		return GUILayout.Button("", customButton, GUILayout.Height(buttonsHeight));
	}

	void OnGUI()
	{
		
		GUI.Label(new Rect(Screen.width-150, 0, 150, 50), "Current Speed: "+scroll.speed);
		
		GUILayout.BeginArea(new Rect(0,Screen.height-buttonsHeight,Screen.width,buttonsHeight));
		GUILayout.BeginHorizontal();
		
		if(CreateButton(CustomColor.red))
		{
			if (!checker.colliding)
				checker.currentColor = CustomColor.red;
		}
		if(CreateButton(CustomColor.yellow))
		{
			if (!checker.colliding)
				checker.currentColor = CustomColor.yellow;
		}
		if(CreateButton(CustomColor.blue))
		{
			if (!checker.colliding)
				checker.currentColor = CustomColor.blue;
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
