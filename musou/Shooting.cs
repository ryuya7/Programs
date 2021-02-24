using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public GameObject Bullet;
	public float Speed = 2;

	void Update(){
		if(Input.GetMouseButton(0)){
			GameObject Bullets = Instantiate(Bullet) as GameObject;
			Vector3 force;
			force = this.gameObject.transform.forward * Speed;
			Bullets.GetComponent<Rigidbody>().AddForce(force);
			Bullets.transform.position = this.gameObject.transform.position;
		}
	}
}
