using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_collision : MonoBehaviour {
	public GameObject boom_sound;
	public GameObject boom_obj;
	public GameObject power_drop;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision info) {
		if (info.gameObject.tag == "laser_1") {
			Instantiate (boom_obj, transform.position, transform.rotation);
			Instantiate (boom_sound, transform.position, transform.rotation);
			drop_power();
			Destroy (this.gameObject);
			Destroy (info.gameObject);
		}
	}

	void drop_power () {

		if (Random.Range (0.0f, 10.0f) > 7.0f) {

			Instantiate (power_drop, transform.position, transform.rotation);
		}
	}

}
