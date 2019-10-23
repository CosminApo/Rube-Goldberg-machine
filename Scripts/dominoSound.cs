using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dominoSound : MonoBehaviour {

    public AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "domino")
        {

            source.Play();
        }
    }
}
