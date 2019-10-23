using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanUp : MonoBehaviour {

    public GameObject ball;
    public GameObject button;
    MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = button.GetComponent<MeshRenderer>();
    }
    void OnCollisionEnter(Collision col)
    {
        Destroy(ball);
        Destroy(meshRenderer);
    }
}
