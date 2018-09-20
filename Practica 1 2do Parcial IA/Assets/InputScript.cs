using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    Rigidbody rb;

    public float velocity = 10f;
    public float jumpForce = 20f;
    bool onGround, jump;
    float directionX;
    float directionZ;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
        directionX = Input.GetAxis("Horizontal");
        directionZ = Input.GetAxis("Vertical");
        jump = Input.GetButtonDown("Jump");

        rb.velocity = new Vector3(directionX * velocity, rb.velocity.y, directionZ * velocity);

        if (jump)
        {
            Jump();
        }
	}

    void Jump()
    {
        rb.AddForce(new Vector3(0, jumpForce, 0));
    }
}
