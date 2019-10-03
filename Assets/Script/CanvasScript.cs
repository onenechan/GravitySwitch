using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour {

	//public Text Highscore;
	//public Text Retry;

	public GameObject gameovertexts;
	public AudioClip audioClip1;
	private AudioSource audioSource;
	bool flg = false;

	// Use this for initialization
	void Start () {
		//Highscore = GameObject.Find("HighScore").GetComponent<Text>();
		//Highscore.enabled = false;
		//Retry.enabled = false;
		audioSource = gameObject.GetComponent<AudioSource>();
		gameovertexts.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		if (GameOverScript.gameover == true && flg == false) {
			//Highscore.enabled = true;
			//Retry.enabled = true;
			audioSource.clip = audioClip1;
			audioSource.Play ();
			gameovertexts.SetActive(true);
			flg = true;
		}
	} 
}