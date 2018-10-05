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


	bool flg = true;

	public static float speed;

	void Start(){
		speed = 8.0f;
		score = 0;
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
			//Debug.Log (Physics.gravity);
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
