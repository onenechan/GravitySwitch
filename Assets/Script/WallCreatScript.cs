using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreatScript : MonoBehaviour {

	public GameObject wall;
	private int DestroyCountMax = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (Time.deltaTime * PlayerScript.speed, 0, 0);
		if (DestroyScript.DestroyCount > DestroyCountMax) {
			transform.position = new Vector3 (transform.position.x , Random.Range (0, 2), 0);
			Instantiate (wall, transform.position, transform.rotation);
			DestroyCountMax = DestroyScript.DestroyCount;
		}
	}
}
