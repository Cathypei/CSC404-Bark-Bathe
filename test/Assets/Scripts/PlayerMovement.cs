using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Movement referencing camera
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Get the forward direction of the camera without its y-component
        Vector3 cameraForward = Camera.main.transform.forward;
        cameraForward.y = 0f;
        cameraForward.Normalize();

        // Get the right direction of the camera without its y-component
        Vector3 cameraRight = Camera.main.transform.right;
        cameraRight.y = 0f;
        cameraRight.Normalize();

        // Calculate the movement direction relative to the camera
        Vector3 movement = (cameraForward * moveVertical + cameraRight * moveHorizontal).normalized;

        // Apply movement to Rigidbody
        rb.velocity = new Vector3(movement.x * speed, rb.velocity.y, movement.z * speed);

        // make the player face the direction it is moving
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
    }
}
