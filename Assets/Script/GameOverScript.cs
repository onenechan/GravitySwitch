using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public ParticleSystem particle;
	public Text Score;

	public static bool gameover;

	// Use this for initialization
	void Start () {
		particle = this.GetComponent<ParticleSystem> ();
		gameover = false;
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("yes");
		Debug.Log (col.gameObject.tag);
		if(col.gameObject.tag == "Enemy"){
			gameover = true;  //Gameover検知
			Debug.Log ("GAMEOVER");
		}
	}

}
