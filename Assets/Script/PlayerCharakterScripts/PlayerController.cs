using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;

    public float WalkingSpeed = 5f;
    public float JumpStrenght = 3f;

    public bool IsOnFloor = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && IsOnFloor)
        {
            // Wenn man Leertaste dr�ckt
            rb.AddForce(Vector2.up * JumpStrenght, ForceMode2D.Impulse);
        }
        else
        {
            // Wenn man nicht Leertaste dr�ckt
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Wenn man D dr�ckt
            rb.AddForce(Vector2.right * WalkingSpeed, ForceMode2D.Impulse);
        }
        else
        {
            // Wenn man nicht D dr�ckt
        }
        if (Input.GetKey(KeyCode.A))
        {
            // Wenn man A dr�ckt
            rb.AddForce(Vector2.left * WalkingSpeed, ForceMode2D.Impulse);
        }
        else
        {
            // Wenn man nicht A dr�ckt
        }
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        IsOnFloor = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        IsOnFloor = false;
    }
}
