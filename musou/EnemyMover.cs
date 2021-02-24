using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMover : MonoBehaviour {
	public GameObject Target;
	public float speed = 1f;
	public float rotationspeed = 1f;
	public float posrange = 10f;
	private Vector3 targetpos;
	public float targetdistance;

	void Move(){
		targetpos = Target.transform.position;
		Quaternion targetRotation = Quaternion.LookRotation(targetpos - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime*rotationspeed);
		transform.Translate(Vector3.forward*speed*Time.deltaTime);
	}

	void Start(){
		Target = GameObject.FindGameObjectWithTag("Player");
		targetpos = Target.transform.position;
	}

	void Update(){
		targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);
		Move();
	}
}
