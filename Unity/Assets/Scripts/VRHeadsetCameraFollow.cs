using UnityEngine;
using UnityEngine.XR;

public class VRHeadsetCameraFollow : MonoBehaviour
{
    public float rotationSpeed = 1.0f; // Adjust the speed of camera rotation.

    private Transform headset;

    private void Start()
    {
        headset = transform.parent; // Get the parent (headset) transform.
    }

    private void Update()
    {
        // Rotate the headset (and camera) to match the headset's rotation.
        InputDevices.GetDeviceAtXRNode(XRNode.Head).TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion headsetRotation);
        headset.localRotation = Quaternion.Slerp(headset.localRotation, headsetRotation, rotationSpeed * Time.deltaTime);

        // Position the camera relative to the headset (optional).
        transform.localPosition = Vector3.zero;
    }
}
