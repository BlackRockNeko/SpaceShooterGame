using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class del_me : MonoBehaviour {
	public float del_time;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, del_time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
