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
		transform.position += new Vector3 (Time.deltaTime * PlayerScript.speed, 0, 0);
		if (timer > interval) {
			transform.position = new Vector3 (transform.position.x , Random.Range (0, 2), 0);
			Instantiate (wall, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
