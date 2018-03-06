using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour {


	private GameObject player;
	private Transform t;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
	}

	// Update is called once per frame
	void LateUpdate () {
		transform.LookAt (player.transform.position);

	}
}