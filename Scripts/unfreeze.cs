using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unfreeze : MonoBehaviour {

    public Rigidbody m_Rigidbody;
    Rigidbody myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "startingSphere")
        {
            myRigidBody.constraints = RigidbodyConstraints.None; //set the constraints to none
            m_Rigidbody.constraints = RigidbodyConstraints.None; //set the constraints to none
            Destroy(myRigidBody);

        }
    }
}
