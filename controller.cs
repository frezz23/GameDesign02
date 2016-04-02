using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	public int score;
		// Update is called once per frame
	void Update () {
		float speed = 15 * Time.deltaTime; //Our Speed in seconds
		
		//Vector3 is a way to Pass 3D Directions or Positions. Very Useful
		if (Input.GetKey (KeyCode.UpArrow)) {
			Debug.Log ("up arrow was pressed");
			transform.Translate (Vector3.forward * speed);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			Debug.Log ("up arrow was pressed");
			transform.Translate (Vector3.back * speed);
		}
		if(Input.GetKey (KeyCode.LeftArrow)) { //If we press the Left Arrow
			Debug.Log("Left Arrow Pressed");
			transform.Translate(Vector3.left * speed); //Moves our Object to the Left
		}
		if(Input.GetKey (KeyCode.RightArrow)) { //If we press the Right Arrow
			Debug.Log("Right Arrow Pressed");
			transform.Translate(Vector3.right * speed); //Moves our Object to the Right
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "coin") {
			score++;
			Debug.Log (score);
			Destroy(other.gameObject);
		}
	}
}
