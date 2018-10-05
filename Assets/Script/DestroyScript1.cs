using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript1 : MonoBehaviour {

	public static int DestroyCount1 = 0;

	void Update(){
		transform.position += new Vector3 (Time.deltaTime * PlayerScript.speed, 0, 0);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Destroy") {
			Destroy (col.gameObject);
			DestroyCount1++;
		}
	}

}
