using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsiotoScript : MonoBehaviour {

	public AudioClip audioClip1;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider col){
		Debug .Log (col.gameObject.tag);
		if (col.gameObject.tag == "Enemy") {
			Debug.Log ("sinu");
			audioSource.clip = audioClip1;
			audioSource.Play ();
		}
	}
}
