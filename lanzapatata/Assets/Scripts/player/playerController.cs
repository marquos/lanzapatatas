using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public int speed;
	private Rigidbody rb;
	private int isJumping;
	private int numMaxSaltos;
	private int counter;
	private Vector3 movement;


	// Use this for initialization
	void Start () {
		this.counter = 0;
		this.rb = GetComponent<Rigidbody> ();
		isJumping = 0;
		numMaxSaltos = 1;

	}
	
	// Update is called once per frame
	void Update () {
		float verticalMovement = Input.GetAxis ("Vertical");
		float horizontalMovement = Input.GetAxis ("Horizontal");
		Vector3 v = new Vector3 (horizontalMovement * Time.deltaTime * speed, 0.0f, verticalMovement * Time.deltaTime * speed);
		transform.Translate (v);

		if (Input.GetKeyDown ("space") && numMaxSaltos > 0) {
			Vector3 jumpForce = new Vector3 (0.0f, 13.0f, 0.0f);
			rb.AddForce (jumpForce, ForceMode.Impulse);
			numMaxSaltos--;
		}
	}

	void OnCollisionEnter (Collision c){
		this.numMaxSaltos = 1;
	}

	void LateUpdate () {
	
	
	}

	public void Jump () {
		Vector3 jumpForce = new Vector3 (0.0f, 13.0f, 0.0f);
		rb.AddForce (jumpForce, ForceMode.Impulse);
		numMaxSaltos--;
	}


}
