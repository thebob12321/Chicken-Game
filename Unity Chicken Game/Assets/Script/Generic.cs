using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Generic : MonoBehaviour {

	// position
	// public float posX; 
	// public float posY; 
	// public float posZ; 
	public Vector3 pos;

	// Rotate
	// public float rotX;
	// public float rotY;
	// public float rotZ;
	// public float rotW;
	public Quaternion rot;

	//Scale
	// public float X = 1f;
	// public float Y = 1f;
	// public float Z = 1f;
	public Vector3 scale;




	// Use this for initialization
	void Start () {
		//Game needs to start to work
		scale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		// transform.position = new Vector3(posX,posY,posZ);
		// transform.rotation = new Quaternion(rotX,rotY,rotZ,rotW);
		// transform.localScale = new Vector3(X,Y,Z);

		transform.position = pos;
		transform.rotation = rot;
		scale = Vector3.one;
	}
}
