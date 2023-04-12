using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_MOVE : MonoBehaviour {
    public Vector3 mypos;
    public Vector2 movespeed;
    public Vector2 movelimt;
	// Use this for initialization
	void Start () {
        mypos = transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(mypos.x + Mathf.PingPong(Time.time * movespeed.x, movelimt.x), 1.0f, mypos.z + Mathf.PingPong(Time.time * movespeed.y, movelimt.y));
        //transform.position.x = mypos.x + Mathf.PingPong(Time.time * movespeed.x, movelimt.x);
        //transform.position.z = mypos.z + Mathf.PingPong(Time.time * movespeed.y, movelimt.y);
    }
}
