using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSpawner : MonoBehaviour {
	public GameObject Spawner;
	private GameObject Player;
	private Vector3 P_pos;
	public float Interval;
	private float timer = 0;
	
	void Start(){
		Player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update(){
		timer -= Time.deltaTime;
		if(timer <= 0){
			timer = Interval;
			P_pos = Player.transform.position;
			P_pos.x += Random.Range(-10f, 10f);
			P_pos.y += Random.Range(-5f, -3f);
			P_pos.z += Random.Range(3f, 5f);
			Instantiate(Spawner, P_pos, Quaternion.identity);
		}
	}
}
