using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballSpeed = 2f;
    public Rigidbody sphereRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballSpeed = 5.0F;
    }

    // Update is called once per frame
    void Update()
    {
        // Intialize the 2D input vector
        Vector2 inputVector = Vector2.zero;

        // Get user input
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }

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
