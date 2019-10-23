﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

    GameObject player;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
 
        transform.position =  player.transform.position + offset;
	}
}
