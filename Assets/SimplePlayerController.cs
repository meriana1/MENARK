using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Speed of the player
    private Rigidbody rb;      // Reference to the Rigidbody component

    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Input handling for player movement
        float moveHorizontal = Input.GetAxis("Horizontal"); // Get horizontal input (A/D or Left/Right arrow keys)
        float moveVertical = Input.GetAxis("Vertical");     // Get vertical input (W/S or Up/Down arrow keys)

        // Create a Vector3 to hold our desired movement direction in the XZ plane
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply the movement to the Rigidbody while maintaining the current y-velocity (gravity)
        rb.velocity = new Vector3(movement.x * speed, rb.velocity.y, movement.z * speed);
    }
}
