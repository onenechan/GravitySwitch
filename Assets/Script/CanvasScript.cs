using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour {

	//public Text Highscore;
	//public Text Retry;

	public GameObject gameovertexts;

	// Use this for initialization
	void Start () {
		//Highscore = GameObject.Find("HighScore").GetComponent<Text>();
		//Highscore.enabled = false;
		//Retry.enabled = false;

		gameovertexts.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		if (GameOverScript.gameover == true) {
			//Highscore.enabled = true;
			//Retry.enabled = true;

			gameovertexts.SetActive(true);
		}
	} 
}