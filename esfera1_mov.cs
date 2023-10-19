using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera1_mov : MonoBehaviour
{
    public float moveSpeed = 1.0f; // Adjust the speed as needed
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Normalize the movement vector to ensure consistent speed in all directions
        movement.Normalize();

        // Apply the movement to the Rigidbody
        rb.velocity = movement * moveSpeed;
    }
}
