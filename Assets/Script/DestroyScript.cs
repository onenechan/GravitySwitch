using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {

	public GameObject wall;

	public static int DestroyCount = 0;

	void Update(){
		transform.position += new Vector3 (Time.deltaTime * PlayerScript.speed, 0, 0);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Destroy") {
			Destroy (col.gameObject);
			DestroyCount++;

			Instantiate (wall, transform.position + Vector3.right*32, transform.rotation);
		}
	}

}
