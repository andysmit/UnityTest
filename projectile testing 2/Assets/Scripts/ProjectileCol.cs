﻿using UnityEngine;
using System.Collections;

public class ProjectileCol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("EHH");
        //if (projectile)
        //print(col.collider.name);
    }
}
