/*
 * Author: Ichiro Miyasato
 * File: BunjiMovement.cs
 * Description: Handles the movement of the Bunji character using input actions.
 */
using UnityEngine;

public class BunjiMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Reference to the generated InputActions class
    private PlayerControls controls;

    void Awake()
    {
        // Initialize the input actions
        controls = new PlayerControls();
    }

    void OnEnable()
    {
        // Enable the input actions
        controls.Enable();
    }

    void OnDisable()
    {
        // Disable when object is inactive
        controls.Disable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Read movement vector from the Input System
        movement = controls.Gameplay.Move.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}