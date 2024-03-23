using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This line says we're using the Unity engine's features
public class Connection : MonoBehaviour
{
    // These lines define variables that we can adjust in Unity Editor
    public Transform connectionPoint; // Where the connection occurs on the object
    public float connectionDistance = 0.1f; // How close objects need to be to connect

    // This variable keeps track of whether the object is already connected
    private bool isConnected = false;

    // This function runs every frame
    void Update()
    {
        // If the object is not already connected, try to connect
        if (!isConnected)
        {
            TryConnect();
        }
    }

    // This function checks for nearby objects and tries to connect with them
    void TryConnect()
    {
        // Find objects within a certain distance from the connection point
        Collider[] colliders = Physics.OverlapSphere(connectionPoint.position, connectionDistance);

        // Check each nearby object
        foreach (Collider col in colliders)
        {
            // If the object is connectable and not itself
            if (col.CompareTag("Connectable") && col.gameObject != gameObject)
            {
                // Connect with the object
                Connect(col.transform);
                // Stop checking for connections after the first one
                break;
            }
        }
    }

    // This function aligns and connects the objects
    void Connect(Transform otherTransform)
    {
        // Align and connect the objects
        // For example, snap this object to the other object's connection point
        transform.position = otherTransform.position;
        transform.rotation = otherTransform.rotation;

        // Add any additional connection logic or effects

        // Mark the object as connected
        isConnected = true;
    }
}
