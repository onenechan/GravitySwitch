using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGeneScr : MonoBehaviour {

	public GameObject point;

	private float timer = 0;
	private float interval = 5.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		transform.position += new Vector3 (Time.deltaTime * PlayerScript.speed, 0, 0);
		if (timer > interval) {
			transform.position = new Vector3 (transform.position.x , Random.Range (-3.0f, 3.0f), 0); 
			Instantiate (point, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
