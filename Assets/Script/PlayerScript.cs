using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerScript : MonoBehaviour {

	float timer = 0;
	public static int score = 0; 
	public Text showScore;
	bool flg = true;

	public static float speed = 5.0f;


	// Use this for initialization
	void Start () {
		Physics.gravity = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update (){
		showScore.text = score.ToString ();
		transform.position += new Vector3 (Time.deltaTime * speed, 0, 0);
		timer += Time.deltaTime;
		if (timer >= 4 && flg) {
			Physics.gravity = new Vector3 (0, -9.8f, 0);
			flg = false;
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (Physics.gravity.y <= 0) {
				Physics.gravity = new Vector3 (0, 20f, 0);
			} else {
				Physics.gravity = new Vector3 (0, -20f, 0);
			}
			//Debug.Log (Physics.gravity);
		}
	}

}
