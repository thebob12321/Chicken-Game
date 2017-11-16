using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public Rigidbody projectile;
	public Transform SpawnPoint;
	public int shootSpeed;
	
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, SpawnPoint.position,projectile.rotation);
			clone.velocity = SpawnPoint.TransformDirection (Vector3.forward*shootSpeed);
		}
	}
}
