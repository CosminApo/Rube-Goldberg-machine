using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recenterBall : MonoBehaviour {

    GameObject player;
    Rigidbody playerRb;
    Vector3 velocity;
   	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerRb = player.GetComponent<Rigidbody>();

	}

    void OnCollisionEnter(Collision col)
    {
        if (playerRb.velocity.z > 0.1 || playerRb.velocity.z < -0.1)
        {
            velocity = playerRb.velocity;
            velocity.z = 0;
            playerRb.velocity = velocity;
        }
    }
}
