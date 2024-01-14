using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed

    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the object
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
