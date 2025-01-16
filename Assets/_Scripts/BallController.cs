using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log(Vector2.up);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log(Vector2.down);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log(Vector2.right);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log(Vector2.left);
        }
    }
}
