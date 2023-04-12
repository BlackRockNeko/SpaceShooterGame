using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_bg : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0, Time.time*speed);
	}
}
