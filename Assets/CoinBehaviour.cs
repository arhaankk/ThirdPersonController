using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation (degrees per second)
    public float jumpHeight = 0.2f;   // How high the coin jumps
    public float jumpSpeed = 2f;      // How fast the jump oscillates

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; // Store the initial position of the coin
    }

    void Update()
    {
        // Rotate the coin around the Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Create a smooth jumping motion using a sine wave
        float newY = startPosition.y + Mathf.Sin(Time.time * jumpSpeed) * jumpHeight;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
