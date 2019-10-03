using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerScript : MonoBehaviour {

	float timer = 0;
	float Maxpos = 0;
	public static int score; 
	public Text showScore;
	public GameObject explotion;
	int pointcountMax;
	private AudioSource audioSource;
	public AudioClip audioClip1;
	public AudioClip audioClip2;
	public AudioClip audioClip3;

	bool flg = true;

	public static float speed;

	void Start(){
		speed = 8.0f;
		score = 0;
		pointcountMax = 0;
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	void Update (){
		showScore.text = score.ToString ();
		transform.position += new Vector3 (Time.deltaTime * speed, 0, 0); //Player移動
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (Physics.gravity.y <= 0) {
				Physics.gravity = new Vector3 (0, 20f, 0);
			} else {
				Physics.gravity = new Vector3 (0, -20f, 0);
			}
		}
		if(PointScript.pointcount > pointcountMax){
			Debug.Log ("nemui");
			audioSource.clip = audioClip1;
			audioSource.Play ();
			pointcountMax = PointScript.pointcount;
		}
		if (GameOverScript.gameover == true && flg) {
			speed = 0;
			Instantiate(explotion,transform.position,Quaternion.identity);
			flg = false;  
			Destroy (this.gameObject); 
		}
		if (transform.position.x >= Maxpos + 20) {
			score++;
			Maxpos = transform.position.x;
		}
	}

}
