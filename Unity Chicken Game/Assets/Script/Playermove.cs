﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;
	public float jumpHeight;

	void Start () {
		
	}

	void Update () {
	var j = Input.GetAxis("Jump")* Time.deltaTime * jumpHeight;
	var y = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
	var z = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;

	transform.Rotate(0,y,0);
	transform.Translate(0,0,z);
	transform.Translate(0,j,0);
	
	}
}
