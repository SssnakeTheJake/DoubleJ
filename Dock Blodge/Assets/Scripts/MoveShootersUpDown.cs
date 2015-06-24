using UnityEngine;
using System.Collections;

public class MoveShootersUpDown : MonoBehaviour {

	float timer = 2;

	//This can be set to pos or neg in the inspector so the shooters can start at opp ends of the board
	public float speed = 4.5f;

	// Use this for initialization
	void Start () {
		//gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (0f, 0f, speed); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (0f, 0f, speed); 

		timer -= .02f;

		if (timer <= 0f) {
			speed = -1 * speed;
			timer = 2f;
		}

	}
}
