using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCart : MonoBehaviour {

    // Use this for initialization
    public Rigidbody m_Rigidbody;
    Rigidbody myRigidBody;
    public Vector3 speed;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "startingSphere")
        {
            Destroy(myRigidBody);
            m_Rigidbody.constraints = RigidbodyConstraints.None; //set the constraints to none
        }

    }
    void Update()
    {
        if (m_Rigidbody.constraints == RigidbodyConstraints.None)
        {
            m_Rigidbody.transform.Translate(speed * Time.deltaTime);
        }
    }
}
