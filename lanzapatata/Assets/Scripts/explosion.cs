using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {
	private Rigidbody rb;
	private float pow = 80.0f;
	private float radius = 6.0f;
	private GameObject gb;
	// Use this for initialization
	void Start () {
		this.rb = GetComponent<Rigidbody>();
		this.gb = GetComponent<GameObject>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "Player") {
			Vector3 positionOfExplosion = transform.position;
			c.rigidbody.AddForce (transform.position, ForceMode.Impulse);
		}
	}
}