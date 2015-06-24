using UnityEngine;
using System.Collections;

public class MoveBlockRight : MonoBehaviour {

	float timer = 6f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (10f, 0f, 0f);
		
	}
	
	void FixedUpdate () {
		
		timer -= .02f;
		
		if (timer <= 0f) {
			Destroy (gameObject);
		}
	}
}
