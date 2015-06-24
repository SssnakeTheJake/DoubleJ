using UnityEngine;
using System.Collections;

public class MoveBlockUp : MonoBehaviour {

	float timer = 6f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (0f, 0f, 10f);

	}

	void FixedUpdate () {

		timer -= .02f;

		if (timer <= 0f) {
			Destroy (gameObject);
		}
	}
}
