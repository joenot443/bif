using UnityEngine;
using System.Collections;


public class BaseObstacle : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		//gameObject.collider2D.enabled = false;
		rigidbody2D.velocity = new Vector2(0.0f, speed);
	}

	// Update is called once per frame
	void Update() {
		Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
		if (hit != null && hit.collider != null) {
			Debug.Log ("I'm hitting "+hit.collider.name);
			Destroy (gameObject);
		}
	}
	
	void OnBecameInvisible() {
		Debug.Log ("Object left the screen: " + GetInstanceID());
		Destroy (gameObject);
	}


	
	void FixedUpdate () {

	}
}
