using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool jumpKeyDown;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        // rigidBodyComponent = GetComponent<Rigigbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyDown = true;
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        if (jumpKeyDown)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyDown = false;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput * 5, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, verticalInput * 5);
    }
}
