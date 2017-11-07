using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Generic : MonoBehaviour {

	// position
	public float posX; 
	public float posY; 
	public float posZ; 
	




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(posX,posY,posZ);
		
	}
}
