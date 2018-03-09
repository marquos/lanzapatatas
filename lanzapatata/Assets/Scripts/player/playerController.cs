﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public int speed;
	private Rigidbody rb;
	private int isJumping;
	private int numMaxSaltos;
	private int counter;
	private Vector3 movement;

	private AudioSource audio;
	public AudioClip fastWalk;
	public AudioClip normalWalk;
	public AudioClip slowWalk;

	private Animator anim;

	// Use this for initialization
	void Awake () {
		this.counter = 0;
		this.rb = GetComponent<Rigidbody> ();
		isJumping = 0;
		numMaxSaltos = 1;
		audio = GameObject.Find ("Movement").GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		float verticalMovement = Input.GetAxis ("Vertical");
		float horizontalMovement = Input.GetAxis ("Horizontal");
		Vector3 v = new Vector3 (horizontalMovement * Time.deltaTime * speed, 0.0f, verticalMovement * Time.deltaTime * speed);
		transform.Translate (v);

	
		if (Input.GetKeyDown ("space") && numMaxSaltos > 0) {
			Vector3 jumpForce = new Vector3 (0.0f, 4.0f, 0.0f);
			rb.AddForce (jumpForce, ForceMode.Impulse);
			numMaxSaltos--;
		}

		audio.clip = this.ClipToSound (); 
		if (!audio.isPlaying && (verticalMovement!= 0.0f || horizontalMovement!= 0.0f)) {
			audio.Play ();
		}
	}

	void OnCollisionEnter (Collision c){
		//anim.SetBool ("jumping", false);
		this.numMaxSaltos++;
	}

	private AudioClip ClipToSound(){
		AudioClip localAudio = this.normalWalk;
		if (Input.GetKey (KeyCode.LeftShift)) {
			localAudio = fastWalk;
		}
		return localAudio;
	}
}
