using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_fire : MonoBehaviour {
	public GameObject bullet;
	public float cd_time;
	public float last_shoot_time;

	// Use this for initialization
	void Start () {
		cd_time = cd_time * Random.Range (0.8F, 1.2F);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > last_shoot_time + cd_time) 
			fire_on ();
		
	}

	void fire_on () {
		last_shoot_time = Time.time;
		GameObject bullet_clone;
		bullet_clone = Instantiate (bullet, transform.position + new Vector3(0, 0, -1.0f), transform.rotation);
	}
}
