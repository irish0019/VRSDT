using UnityEngine;

public class CarBumperDistance : MonoBehaviour
{
    public float maxDistance = 6.0f; // Maximum distance to check for objects.
    public LayerMask obstacleLayer; // Layer mask for objects you want to check.

    private Transform bumperTransform; // The transform of the car's bumper.\
    private DistanceDisplay distanceDisplay;

    private void Start()
    {
        bumperTransform = transform; // Assign the bumper's transform here.
        distanceDisplay = FindObjectOfType<DistanceDisplay>();
    }

    private void Update()
    {
        // Cast a ray forward from the bumper's position.
        Ray ray = new Ray(bumperTransform.position, bumperTransform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistance, obstacleLayer))
        {
            // An object is closer than maxDistance.
            float distanceToObstacle = hit.distance - 2.3f; // Subtract 2.2 feet.
            distanceDisplay.UpdateDistance(distanceToObstacle);
        }
        else
        {
            // No obstacle within maxDistance.
            Debug.Log("No obstacle within " + (maxDistance - 2.3f) + " feet");
            distanceDisplay.UpdateDistance(4);
        }
    }
}
