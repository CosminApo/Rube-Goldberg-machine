using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showEndMenu : MonoBehaviour {

    public GameObject endMenu;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "startingSphere")
        {
            endMenu.SetActive(true);
        }

    }
}
