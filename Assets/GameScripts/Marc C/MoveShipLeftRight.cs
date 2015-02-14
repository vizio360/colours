using UnityEngine;
using System.Collections;

public class MoveShipLeftRight : MonoBehaviour {

	private Vector2 touchpos1;
	private Vector2 touchpos2;

	public float moveAmount = 10f;
	public float playerPos = 0;

	void Start()
	{
		//moveAmount = Screen.width / 3;
	}
	
	// Update is called once per frame
	void Update () {
		MovePlayer ();

		if(Input.GetKeyDown(KeyCode.LeftControl) && playerPos != 10)
		{
			this.gameObject.transform.Translate(Vector3.left*moveAmount);
			playerPos += 10;
		}
		if(Input.GetKeyDown(KeyCode.RightControl) && playerPos != -10)
		{
			this.gameObject.transform.Translate(Vector3.right*moveAmount);
			playerPos -= 10;
		}
	
	}

	void MovePlayer()
	{
		foreach(var touch in Input.touches)
   		{
          if (touch.phase == TouchPhase.Began)
          {
                touchpos1 = touch.position;
                touchpos2 = touch.position;
          }

          if (touch.phase == TouchPhase.Moved )
          {
                touchpos1 = touch.position;
          }

          if(touch.phase == TouchPhase.Ended)
          {      
                if((touchpos1.x - touchpos2.x) > 80 && playerPos != -10) // right swipe
          		{
					this.gameObject.transform.Translate(Vector3.right*moveAmount);
					playerPos += -10;
          		}
				else if((touchpos1.x - touchpos2.x) < -80 && playerPos != 10) // left swipe
				{
					this.gameObject.transform.Translate(Vector3.left*moveAmount);
					playerPos += 10;
				}
          }
      }
	}
}
