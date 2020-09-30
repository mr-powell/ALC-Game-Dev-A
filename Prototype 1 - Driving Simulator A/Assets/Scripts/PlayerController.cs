using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Access Modifier Type Name Operator Value
    private int speed = 20;
    private float turnSpeed = 50;

    private float horizontalInput;
    private float forwardInput;    

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward & back based on forwardInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates vehicle left and right based on horizontalInput
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
