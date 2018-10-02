using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreatScript : MonoBehaviour {

	public GameObject wall;

	private float timer = 0;
	private float interval = 1.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > interval) {
			transform.position = new Vector3 (10, Random.Range (0, 2), -10); 
			Instantiate (wall, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
