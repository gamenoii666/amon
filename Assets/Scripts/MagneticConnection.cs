using UnityEngine;

public class MagneticConnection : MonoBehaviour
{
    public float magnetStrength = 10f; // Adjust the strength of the magnetic attraction

    void FixedUpdate()
    {
        // Detect other objects within a certain range
        Collider[] colliders = Physics.OverlapSphere(transform.position, 5f);

        foreach (Collider col in colliders)
        {
            if (col.CompareTag("MagneticObject") && col.gameObject != gameObject)
            {
                // Calculate the direction from this object to the target
                Vector3 direction = col.transform.position - transform.position;

                // Apply a force towards the target using a magnetic strength
                col.gameObject.GetComponent<Rigidbody>().AddForce(-direction.normalized * magnetStrength);
            }
        }
    }
}
