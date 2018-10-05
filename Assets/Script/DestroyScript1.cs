using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript1 : MonoBehaviour {

	public GameObject wall1;

	void Update(){
		//transform.position += new Vector3 (Time.deltaTime * PlayerScript.speed, 0, 0);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Destroy") {
			Destroy (col.gameObject);
			Instantiate (wall1,new Vector3 (transform.position.x + 41, Random.Range (4, 6), 0) , transform.rotation);
		}
	}

}
