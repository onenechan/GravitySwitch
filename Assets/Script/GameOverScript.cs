using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public ParticleSystem particle;
	public Text Score;
	public Text HighScore;
	public Text Retry;

	// Use this for initialization
	void Start () {
		particle = this.GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("yes");
		Debug.Log (col.gameObject.tag);
		if(col.gameObject.tag == "Enemy"){
			Debug.Log ("GAMEOVER");
		}
	}

}
