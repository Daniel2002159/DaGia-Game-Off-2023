using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterScript : MonoBehaviour
{
    [Header("Movement")]
    [Tooltip("Speed of horizontal Movement")]
    [Range(5, 15)]
    [SerializeField] float speed = 1;
    private Vector2 movementInput = Vector2.zero;

    Rigidbody2D rb;

    // OnMove checks if controls for the movement are pressed
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Get the rigidbody attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    // Move is the method that includes running mechanics
    void Move()
    {
        // Add force to the player rigidbody in the direction of the input, the movementInput.x
        rb.velocity = new Vector2(movementInput.x * speed, rb.velocity.y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
}   