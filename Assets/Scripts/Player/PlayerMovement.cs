using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotate : MonoBehaviour
{
    public float movementSpeed = 5f;   
    public float rotationSpeed = 100f;  

    void Update()
    {
        // Input untuk maju/mundur (W/S)
        float moveInput = Input.GetAxis("Vertical"); 
        transform.Translate(Vector3.up * moveInput * movementSpeed * Time.deltaTime); 

        // Input untuk rotasi (A/D)
        float rotationInput = Input.GetAxis("Horizontal"); // A/D (atau Left/Right arrow)
        transform.Rotate(0, 0, -rotationInput * rotationSpeed * Time.deltaTime); 
    }
}