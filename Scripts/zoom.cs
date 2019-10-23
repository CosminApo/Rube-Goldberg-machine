using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{

    GameObject player;
    followPlayer cameraScript;
    public Vector3 zoomAmount;
    Vector3 currentZoom;
    public float zoomspeed;
    bool flag;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera");
        cameraScript = player.GetComponent<followPlayer>();
        flag = false;
    }
    void Update()
    {
        if (flag && currentZoom != zoomAmount)
        {
            cameraScript.offset += currentZoom;
            currentZoom.z -= zoomspeed;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "Untagged")
            flag = true;
          
    }
}
