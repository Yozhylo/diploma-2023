using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fish : Entity {
	private float MinimumTankSize {
		set; get;
	}
	private float speed = 2.0f;
	Fish() {
	
	}
	private void Update() {
		Move();
		Decay();
	}
	private void Move() {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

}