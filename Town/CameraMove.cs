using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public float xSpeed;
	public float zSpeed;
	public float ySpeed;
	public float yMax;
	public float yMin;
	public GameObject Field;
	
	float xMax, zMax, interval;

	void Start () {
		interval = Field.GetComponent<CellCreate>().Interval;
		xMax = interval * Field.GetComponent<CellCreate>().matX;
		zMax = interval * Field.GetComponent<CellCreate>().matZ;
	}
	
	void Update () {
		Transform myTransform = this.transform;
		Vector3 pos = myTransform.position;


		if(Input.GetKey(KeyCode.W)){
			pos.z += zSpeed;
			if(pos.z >= zMax){
				pos.z = zMax;
			}
		}
		if(Input.GetKey(KeyCode.S)){
			pos.z -= zSpeed;
			if(pos.z <= 0.0f){
				pos.z = 0.0f;
			}
		}
		if(Input.GetKey(KeyCode.D)){
			pos.x += xSpeed;
			if(pos.x >= xMax){
				pos.x = xMax;
			}
		}
		if(Input.GetKey(KeyCode.A)){
			pos.x -= xSpeed;
			if(pos.x <= 0.0f){
				pos.x = 0.0f;
			}
		}
		if(Input.GetKey(KeyCode.Space)){
			pos.y += ySpeed;
			if(pos.y >= yMax){
				pos.y = yMax;
			}
		}
		if(Input.GetKey(KeyCode.LeftShift)){
			pos.y -= ySpeed;
			if(pos.y <= yMin){
				pos.y = yMin;
			}
		}
		myTransform.position = pos;
	}
}
