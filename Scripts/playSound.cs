using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour {

    public AudioSource source;
  
    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();

    }
	
    void OnCollisionEnter(Collision col)
    {
        if (source.isPlaying == false  )
        {
           
            source.Play();
        }
    }
}
