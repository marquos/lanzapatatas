using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterController : MonoBehaviour {

	public GameObject shootable;
	private GameObject player;
	private Transform t;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
		t = shootable.transform;
		StartCoroutine (Fire());
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.LookAt (player.transform.position);
	}

	private IEnumerator Fire(){

		while (true) {
			
			GameObject shoot = (GameObject)Instantiate (shootable, shootable.transform.forward* 1.5f, t.rotation);
			shoot.SetActive (true);
			shoot.transform.LookAt (player.transform.position);
			Vector3 diffForce = player.transform.position - shoot.transform.position;
			shoot.GetComponent <Rigidbody> ().velocity = diffForce * 1;

			Destroy (shoot, 1);
			yield return new WaitForSeconds (2.0f);
		}
	}
}
