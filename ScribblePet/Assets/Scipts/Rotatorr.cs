﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatorr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * Time.deltaTime * 150);
	}
}
