using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour {
	//private  movetp;
	public float PC_SPEED;
	public float ANDROID_SPEED;
	public float FLY_LIMT_X;
	public float FLY_LIMT_Y;
	public SimpleTouchController leftController;

	// Use this for initialization
	void Start () {
        leftController = Object.FindObjectOfType<SimpleTouchController>();
            
     }
	
	// Update is called once per frame
	void Update () {
		transform.Translate (leftController.GetTouchPosition.x*PC_SPEED*Time.deltaTime, 0, leftController.GetTouchPosition.y*PC_SPEED*Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp (transform.position.x, -FLY_LIMT_X, FLY_LIMT_X), 1.0F, Mathf.Clamp (transform.position.z, -FLY_LIMT_Y, FLY_LIMT_Y));
        transform.Translate(Input.GetAxis("Horizontal") * PC_SPEED * Time.deltaTime, 0, Input.GetAxis("Vertical") * PC_SPEED * Time.deltaTime);

    }
}
