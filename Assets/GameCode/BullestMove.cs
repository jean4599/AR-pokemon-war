﻿using UnityEngine;
using System.Collections;

public class BullestMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3(0.01f,0,0);
		if (gameObject.transform.position.x > 3 || 
			gameObject.transform.position.y > 3 || 
			gameObject.transform.position.z > 3) {

			Destroy (gameObject);
		}
	}
}