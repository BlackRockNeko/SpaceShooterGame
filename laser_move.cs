using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_move : MonoBehaviour {
    public float speed;
    public float fly_z_limt;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed*Time.deltaTime);
        if ((transform.position.z > fly_z_limt) || (transform.position.z < -fly_z_limt))
        {
            Destroy(this.gameObject);
        }
	}
}
