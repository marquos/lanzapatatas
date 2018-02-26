using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

	public GameObject bullet;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		CheckFire ();

	}

	void CheckFire () {
		if (Input.GetMouseButtonDown (0)) {
			//anim.SetBool ("shooting", true);

			Debug.Log ("shoot");

			GameObject shoot = Instantiate (bullet) as GameObject;
			shoot.SetActive (true);
			shoot.transform.position = transform.position + transform.forward * 2;
			shoot.transform.LookAt (transform.position + transform.forward * 3);
			shoot.GetComponent<Rigidbody> ().velocity = transform.forward * 35;

			Destroy (shoot, 2);


		} 
	}
}
