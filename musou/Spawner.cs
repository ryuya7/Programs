using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject Enemy;
	private Vector3 MyPos;
	public float Int;
	private float timer;
	
	void Update(){
		timer -= Time.deltaTime;
		if(timer <= 0){
			MyPos = this.transform.position;
			Instantiate(Enemy, MyPos, Quaternion.identity);
			timer = Int;
		}
	}
}
