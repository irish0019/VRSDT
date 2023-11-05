using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Assign the car object in the Inspector.

    public float smoothSpeed = 1f; // Adjust the smoothness of the camera movement.
    public float rotationSpeed = 3.0f; // Adjust the speed of camera rotation.

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position;

            // Rotate the camera to match the car's rotation
            Quaternion desiredRotation = target.rotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
