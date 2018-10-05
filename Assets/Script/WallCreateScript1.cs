using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreateScript1 : MonoBehaviour {

	public GameObject wall;
	private int DestroyCountMax = 0;

	void Update () {
		transform.position += new Vector3 (Time.deltaTime * PlayerScript.speed, 0, 0);
		if (DestroyScript1.DestroyCount1 > DestroyCountMax) {
			transform.position = new Vector3 (transform.position.x, Random.Range (-2, 0), 0);
			Instantiate (wall, transform.position, transform.rotation);
			DestroyCountMax = DestroyScript1.DestroyCount1; 
		} 
	}
}

