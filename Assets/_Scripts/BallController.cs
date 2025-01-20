using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private Rigidbody sphereRigidbody;

    public void MoveBall(Vector2 inputVector)
    {
        // Create a 3D version of the 2D input vector
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);

        // Check for input
        if (inputXZPlane != Vector3.zero)
        {
            // Log result vectors
            Debug.Log("Resultant 2D Vector: " + inputVector);
            Debug.Log("Resultant 3D Vector: " + inputXZPlane);

            // Apply force the the sphere rigid body
            sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
        }
    }
}
