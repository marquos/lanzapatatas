﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator_controller : MonoBehaviour {

	private Animator anim; 
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		float verticalMovement = Input.GetAxisRaw ("Vertical");
		if (verticalMovement != 0.0f) {
			anim.SetBool ("is_moving", true);
		} else {
			anim.SetBool ("is_moving", false);
		}

		if (Input.GetKey ("space")) {
			anim.SetBool ("is_jumping", true);
		} else {
			anim.SetBool ("is_jumping", false);
		}
	}
}
