using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	void Start(){
		
	}

	void Update () {
		transform.position += new Vector3 (Time.deltaTime * PlayerScript.speed, 0, 0); //Player移動
		if(GameOverScript.gameover == true){
			if (Input.GetKey (KeyCode.Space)) {
				SceneManager.LoadScene ("main");
			}
		}
	}

}
