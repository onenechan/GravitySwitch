using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {


	public GameObject wall;

	void Update(){
		//transform.position += new Vector3 (Time.deltaTime * PlayerScript.speed, 0, 0);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Destroy") {
			Destroy (col.gameObject);

			Instantiate (wall,new Vector3 (transform.position.x + 41, Random.Range (-6, -4), 0) , transform.rotation);
		}
	}

}
