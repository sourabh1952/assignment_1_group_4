using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float rotationSpeed = 111f; // Speed of rotation
    public float moveSpeed = 4f; // Speed of movement
    private Rigidbody rb; // Rigidbody component
    public float jumpForce = 5f; // Force applied when jumping
    // public LayerMask groundLayer; // Layer to identify the ground
    // public GameObject planeCheck;
    private bool isGrounded; // To check if the cube is on the ground
    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the cube based on keyboard input
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        // Move the cube forward based on keyboard input
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        // isGrounded = Physics.CheckSphere(transform.position - new Vector3(0, 0.5f, 0), 0.1f, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space)  && (Mathf.Abs(transform.position.y - 0.5f) < 0.01f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
