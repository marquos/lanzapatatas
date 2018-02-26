using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeEnemyScript : MonoBehaviour {
	[SerializeField]
	Transform location;
	NavMeshAgent iaAgent;

	[SerializeField]
	Transform [] positions;

	Transform actualWayPoint;
	int index;

	// Use this for initialization
	void Awake () {
		index = 0;
		actualWayPoint = positions [index];

		iaAgent = GetComponent <NavMeshAgent> ();
		iaAgent.SetDestination (actualWayPoint.position);
	}

	void Update () {
		//Debug.Log (Vector3.Distance (actualWayPoint.position, this.transform.position));
		if(Vector3.Distance(actualWayPoint.position, this.transform.position) < 1.0f){
			UpdateActualWayPoint ();
		}
	}

	void UpdateActualWayPoint(){
		index++;
		if (index >= 4) {
			index = 0;
		}
		actualWayPoint = positions [index];
		iaAgent.SetDestination (actualWayPoint.position);
	}

	void Shooted (){
		
		
	}

	private bool CheckIfPlayerIsNear(){
		bool playerIsNear = false;
		Collider[] listOfColliders = Physics.OverlapSphere (this.transform.position, 3.0f);
		int index = 0;

		while (index < listOfColliders.Length) {
			if (listOfColliders [index].name == "Animation") {
				Debug.Log (listOfColliders [index].name);
				playerIsNear = true;
			
			} else {
				Debug.Log (listOfColliders [index].name + "no es el jugador");
			
			}

			index++;
		}
		return playerIsNear;
	}
}
