using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adforce : MonoBehaviour
{

    private Rigidbody Rigidbodyrb;
    public float Speed = 5.0f; 

    void Start()
    {
        Rigidbodyrb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float forwardForce = Input.GetAxis("Vertical") * Speed;

        Rigidbodyrb.AddRelativeForce(0f, 0f, forwardForce);
    }
}
