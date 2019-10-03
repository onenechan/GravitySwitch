using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour {

	public float speed = 5.0f; 
	public AudioSource audioSource;
	public static int pointcount = 0;

	void Start(){
		transform.rotation = Quaternion.AngleAxis(45, new Vector3(1, 1, 0));
		audioSource = this.gameObject.GetComponent<AudioSource>();
	} 

	void Update () {

		transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.World);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			pointcount++;
			PlayerScript.score++;
			audioSource.Play ();
			Destroy (this.gameObject);
		}
	}
}
