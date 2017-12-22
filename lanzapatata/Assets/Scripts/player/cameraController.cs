using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

	private Transform transformParent;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		transformParent = this.transform.parent.gameObject.transform;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		float verticalRotation = Input.GetAxis ("Mouse X");
		float horizontalRotation = Input.GetAxis ("Mouse Y");

		Vector3 actualRotation = this.transform.rotation.eulerAngles;
		actualRotation.x -= horizontalRotation;
		this.transform.rotation = Quaternion.Euler (actualRotation);

		Vector3 parentRotation = this.transformParent.rotation.eulerAngles;
		parentRotation.y += verticalRotation;
		this.transformParent.rotation = Quaternion.Euler (parentRotation);
	
		CheckFire();
	}

	void CheckFire () {
		if (Input.GetMouseButtonDown (0)) {
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
