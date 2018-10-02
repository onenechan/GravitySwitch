using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour {

	public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-Time.deltaTime * speed, 0, 0);
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("a");
		if (col.gameObject.tag == "Player") {
			PlayerScript.score++;
			Debug.Log (PlayerScript.score);
			Destroy (this.gameObject);
		}
	}


}
