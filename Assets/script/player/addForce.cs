using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{

    public Rigidbody rb;
    public float force = 3f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad0))
        {
            rb.AddForce(transform.up * force);
        }

    }
}
