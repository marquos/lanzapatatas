using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimButtonScript : MonoBehaviour {

	private Animator anim; 
	private Rigidbody rb;
	private float speed;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		speed = 0f;
	}

	/* Update is called once per frame
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
	}*/

	public void moveUp (){
		anim.SetBool ("is_moving", true);
		anim.SetFloat ("speed", 1.0f);
	}

	public void moveBack (){
		anim.SetBool ("is_moving", true);
	}

	public void moveLeft (){
		anim.SetBool ("is_moving", true);
	}

	public void moveRight (){
		anim.SetBool ("is_moving", true);
	}

	void OnCollisionEnter(){
		anim.SetBool ("is_jumping", false);
	}
}
