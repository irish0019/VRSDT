using UnityEngine;
using TMPro; // Import the TextMesh Pro namespace.

public class DistanceDisplay : MonoBehaviour
{
    public TextMeshProUGUI distanceText; // Use TextMeshProUGUI instead of Text.

    private void Start()
    {
        // Find the TextMeshProUGUI component.
        distanceText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDistance(float distance)
    {
        // Update the TMP Text to display the distance.
        if (distance == 4) {
            Debug.Log("No obstacles");
        }
        else
        {
            Debug.Log("obstacle at: " + distance + " feet");
        }
        // distanceText.text = distance.ToString("F2") + " feet";
    }
}
