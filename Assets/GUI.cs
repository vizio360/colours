using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {
	
	private GUIStyle customButton;
	private int buttonsHeight = 60;
	// Use this for initialization
	void Start () {
		customButton = new GUIStyle();
		print(Colors.getRandomPrimaryColor());
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
		CollisionColorCheck c = spaceship.GetComponent<CollisionColorCheck>();
		if(CreateButton(CustomColor.red))
		{
			if (!c.colliding)
				spaceship.renderer.material.color = CustomColor.red;
		}
		if(CreateButton(CustomColor.yellow))
		{
			if (!c.colliding)
				spaceship.renderer.material.color = CustomColor.yellow;
		}
		if(CreateButton(CustomColor.blue))
		{
			if (!c.colliding)
				spaceship.renderer.material.color = CustomColor.blue;
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
