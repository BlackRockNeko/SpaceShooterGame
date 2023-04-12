using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat_power : MonoBehaviour {
	public GameObject power_up_sound;
	public GameObject gm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision info) {
		if (info.gameObject.tag == "power_up") {
			Destroy (info.gameObject);
			Instantiate (power_up_sound, transform.position, transform.rotation);
			if (gm.GetComponent<Fire> ().power_level < 3)
            {
                gm.GetComponent<Fire>().power_level = gm.GetComponent<Fire>().power_level + 1;
                gm.GetComponent<Fire>().power_up_time = gm.GetComponent<Fire>().power_up_time + 10.0F;
            }
				
		}
	}
}
