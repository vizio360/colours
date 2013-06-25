using UnityEngine;
using System.Collections;



public class GUI : MonoBehaviour {
	
	private GUIStyle customButton;
	private int buttonsHeight = 10	;
	// Use this for initialization
	void Start () {
		customButton = new GUIStyle();
	}
	
	// Update is called once per frame
	void Update () {
	
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
		var spaceship = GameObject.Find("Spaceship");
		GUILayout.BeginArea(new Rect(0,Screen.height-buttonsHeight,Screen.width,buttonsHeight));
		GUILayout.BeginHorizontal();
		if(CreateButton(CustomColor.red))
		{
			spaceship.renderer.material.color = CustomColor.red;
		}
		if(CreateButton(CustomColor.yellow))
		{
			spaceship.renderer.material.color = CustomColor.yellow;
		}
		if(CreateButton(CustomColor.blue))
		{
			spaceship.renderer.material.color = CustomColor.blue;
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
