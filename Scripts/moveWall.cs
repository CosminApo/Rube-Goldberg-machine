using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall : MonoBehaviour {

    public GameObject wallToMove;
    bool flag;
    public Vector3 speed;
    public Vector3 endpoint;
    // Use this for initialization
    void Start () {
        flag = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (flag && wallToMove.transform.position.z < endpoint.z)
            wallToMove.transform.Translate(speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        flag = true;
    }
}
