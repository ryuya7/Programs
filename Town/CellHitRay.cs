using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellHitRay : MonoBehaviour {

	void FixedUpdate(){
		GetComponent<MeshRenderer>().material.color = Color.white;
	}
}
