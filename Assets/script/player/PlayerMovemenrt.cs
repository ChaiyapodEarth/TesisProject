using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemenrt : MonoBehaviour
{

    public CharacterController controller;

    [SerializeField]
    public float speed = 12f;
    public float gravity = 1f;
    public float up = 1f;
    public float down = 3f;

    public float maxGravity = 65f;
    public float minGravity = -100f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public bool isUnderWater = false;
    public bool isBCD = true;

    Vector3 velocity;
    bool isGrounded;  

    void Update()
    {
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        moveMent();
        setGravity();
    }

    public static float maxPosition = -48.92733f;

    public float positionAsPercentage
    {
        get { return -(transform.position.y)/ maxPosition; }
    }

    private void moveMent()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
       // velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.Keypad0))
        {
           gravity += up;
        }

        if (Input.GetKey(KeyCode.Keypad1))
        {
            gravity -= down;    
        }
    }

    private void setGravity()
    {
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        if (gravity >= maxGravity)
        {
            gravity = maxGravity;
        }
        if (gravity <= minGravity)
        {
            isBCD = false;
            gravity = minGravity;
        }
        if (!isGrounded && !isUnderWater)
        {
            isUnderWater = true;
        }


        if (Input.GetKey(KeyCode.Keypad3) && isGrounded == false)
        {
            gravity = 0;
        }
    }
}
