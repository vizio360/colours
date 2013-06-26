using UnityEngine;
using System.Collections;

public class GameControls : MonoBehaviour {
	
	void Awake() {
		Time.timeScale = 1.0f;
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			if (Time.timeScale == 1.0f)
			{
				Time.timeScale = 0.0f;
				this.gameObject.AddComponent("MainMenuGUI");
			}
			else if (Time.timeScale == 0.0f)
			{
				Time.timeScale = 1.0f;
				Destroy(this.gameObject.GetComponent<MainMenuGUI>());
			}
		}
		
	}
}
