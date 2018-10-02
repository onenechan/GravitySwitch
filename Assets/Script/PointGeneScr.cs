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
		if (timer > interval) {
			transform.position = new Vector3 (10, Random.Range (-3.0f, 3.0f), 0); 
			Instantiate (point, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
