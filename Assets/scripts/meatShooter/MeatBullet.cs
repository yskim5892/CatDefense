﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatBullet : MonoBehaviour {

	public float speed;
	public Vector3 direction;
	public MeatSpecies meatSpecies;
	public CuttingResult meatSize;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 greenDir = transform.up;
		transform.position += speed * greenDir;
	}
}
