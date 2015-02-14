using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {

	void OnGUI() {
		GUILayout.BeginArea(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 100, 100, 100));
		GUILayout.BeginVertical();
		
		if(GUILayout.Button ("Start", GUILayout.Height(50))) {
			Application.LoadLevel(1);
		}
		if(GUILayout.Button ("Quit", GUILayout.Height(50))) {
			Application.Quit();
		}
		
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}
}
