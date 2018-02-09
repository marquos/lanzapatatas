using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraController : MonoBehaviour {

	private Transform transformParent;
	public GameObject bullet;
	public Text lifeText;
	private int life;

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
	


	}


}
