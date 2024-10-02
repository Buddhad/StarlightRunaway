using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of the spacecraft

    // Update is called once per frame
    void Update()
    {
        // Get the input from the WASD keys
        float horizontalInput = Input.GetAxis("Vertical");
        float verticalInput = Input.GetAxis("Horizontal");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // Apply the movement to the spacecraft
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
