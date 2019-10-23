using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treadmill : MonoBehaviour {


    public Vector3 force;
    public GameObject player;
    Rigidbody rb;

    // Use this for initialization
    void Start () {

        rb = player.GetComponent<Rigidbody>();
	}
	

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        rb.velocity = force;
    }
}
