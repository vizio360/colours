using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectablesController : MonoBehaviour {
	
	public GameObject collectable;
	
	public int numberOfCollectables = 10;
	
	protected IList<Transform> poolOfCollectables;
	
	float interval = 0;
	
	float screenWidth = Screen.width;
	float screenHeight = Screen.height;
	
	// Use this for initialization
	void Start () {
	
		poolOfCollectables = new List<Transform>(numberOfCollectables);
		GameObject c;
		for (int i=0; i < numberOfCollectables ; i++)
		{
			c = Instantiate(Resources.Load("collectable", typeof(GameObject))) as GameObject;
			c.transform.position = Camera.mainCamera.ScreenToWorldPoint(new Vector3(screenWidth*0.5f, screenHeight-100, 10.0f));
			poolOfCollectables.Add(c.transform);
		}
		isSpawning = false;
	}
	
	
	private bool isSpawning;
	private float spawnInterval;
	private float curTime;
	// Update is called once per frame
	void Update () {
		
		//Random interval timer
	
		//spawn collectibles
		if (!isSpawning)
		{
			spawnInterval = Random.Range(0.1f, 1.5f);
			curTime = Time.time;
			isSpawning = true;
			return;
		}
	
	}
	
	void SpawnCollectibles()
	{
		
	}
	
	void MoveCollectibles()
	{
		foreach (Transform t in poolOfCollectables)
		{
			transform.Translate(Vector3.down*Time.deltaTime);	
		}
	}
}