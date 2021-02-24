using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {
	private float time;
	public float Live = 10f;

	void OnCollisionEnter(Collision col){
		Destroy(this.gameObject);
	}

	void Update(){
		time += Time.deltaTime;
		if(time >= Live)
			Destroy(this.gameObject);
	}
}
