using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheel : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // Adjust the rotation speed as needed.
    public float resetSpeed = 50.0f; // Speed at which the steering wheel resets.
    public float maxRotationAngle = 45.0f; // Maximum allowed rotation angle.

    private Quaternion initialRotation;
    private float currentRotation = 0.0f;

    private void Start()
    {
        initialRotation = transform.localRotation;
    }

    private void Update()
    {
        float rotateAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        // Update the current rotation based on the input.
        currentRotation += rotateAmount;

        // Check if the rotation is within the allowed range.
        currentRotation = Mathf.Clamp(currentRotation, -maxRotationAngle, maxRotationAngle);

        // Apply the rotation to the steering wheel.
        transform.localRotation = initialRotation * Quaternion.Euler(0, 0, currentRotation);

        // Check if no input is received, then reset the steering wheel.
        if (Input.GetAxis("Horizontal") == 0)
        {
            float resetAmount = resetSpeed * Time.deltaTime;
            currentRotation = Mathf.Lerp(currentRotation, 0.0f, resetAmount);
        }
    }
}
