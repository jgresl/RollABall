using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

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

        // Send the input data to the OnMove event
        OnMove?.Invoke(inputVector);
    }
}
