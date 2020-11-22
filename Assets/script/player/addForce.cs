using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{

    public Rigidbody rb;
    public float force = 3f;
    public float forceDown = 3f;
    public float forceForward = 3f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad0))
        {
            rb.AddForce(transform.up * force);
        }
        if (Input.GetKey(KeyCode.Keypad1))
        {
            rb.AddForce(transform.up * forceDown);
        }


        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(transform.forward * forceForward);
        }
       

    }
}
