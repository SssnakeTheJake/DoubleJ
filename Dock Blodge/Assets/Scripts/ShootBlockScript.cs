using UnityEngine;
using System.Collections;

public class ShootBlockScript : MonoBehaviour {

	public GameObject cube1;
	public GameObject cube2;
	public GameObject cube3;

	//change this in the inspector to change the initial time it takes to shoot the block
	public float timer = 1.5f;
	//public float timeSet = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		timer -= .02f;
		if (timer <= 0) {
			int random = Random.Range (1,4);
			if (random == 1) {
				Instantiate(cube1, gameObject.transform.position, gameObject.transform.rotation);
				//GameObject cub1 = GameObject.Find("cube1");
				//cub1.rigidbody.velocity = new Vector3(-5f, 0f, 0f);
			};
			if (random == 2) {
				Instantiate(cube2, gameObject.transform.position, gameObject.transform.rotation);
			};
			if (random == 3) {
				Instantiate(cube3, gameObject.transform.position, gameObject.transform.rotation);
			};

			float random2 = Random.Range (2.25f, 3.5f);
			//float random2 = Random.Range (.75f, 1.8f);
			//float random2 = Random.Range (2.72f, 5.64f);
			timer = random2;

			//timer = timeSet;
		}
	}
}
