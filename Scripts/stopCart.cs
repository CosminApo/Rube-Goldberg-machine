using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopCart : MonoBehaviour {

    startCart myCartScript;
    public GameObject cart;
    Vector3 speed;
    bool hit;

    void Start()
    {
        hit = false;
        myCartScript = cart.GetComponent<startCart>();
        speed = myCartScript.speed;
    }

   void OnTriggerEnter(Collider col)
    {
        hit = true;
	}

    void Update()
    {
        if (hit && myCartScript.speed.x > 0)
        {
            speed.x -= (float)0.1;
            myCartScript.speed = speed; //set cart speed to 0
        }
   
    }
}
