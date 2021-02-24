using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMover : MonoBehaviour {
	
	public GameObject CameraRig;
	private Vector3 pos;

	void Update(){
		pos.x = CameraRig.transform.position.x;
		pos.z = CameraRig.transform.position.z;

		this.transform.position = pos;
	}
}
