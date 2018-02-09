using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeEnemyScript : MonoBehaviour {
	[SerializeField]
	Transform location;
	NavMeshAgent iaAgent;

	Vector3 iniPosition;
	Vector3 nextPosition;
	Vector3 actualWayPoint;

	// Use this for initialization
	void Awake () {
		iniPosition = this.transform.position;
		nextPosition = this.iniPosition + new Vector3 (10.0f, 0.0f, 5.0f);
		actualWayPoint = nextPosition;

		iaAgent = GetComponent<NavMeshAgent>();
		iaAgent.SetDestination (nextPosition);
	}

	void Update () {
		Vector3 v = actualWayPoint - this.transform.position;
		Debug.Log (Vector3.Distance (actualWayPoint, this.transform.position));
		if(Vector3.Distance(actualWayPoint, this.transform.position) < 1.5f){
			UpdateActualWayPoint ();
		}
	}

	void UpdateActualWayPoint(){
		if (actualWayPoint == iniPosition) {
			actualWayPoint = nextPosition;
		} else {
			actualWayPoint = iniPosition;
		}
		iaAgent.SetDestination (actualWayPoint);
	}
}
