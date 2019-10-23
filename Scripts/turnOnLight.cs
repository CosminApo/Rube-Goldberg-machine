using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnLight : MonoBehaviour {

    public GameObject lamp;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "startingSphere")
        {
            lamp.SetActive(true);
        }

    }
}
