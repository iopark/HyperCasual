using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;

    public UnityEvent UponJump; 
    public UnityEvent UponContact;
    public UnityEvent UponScore; 

    private void Awake()
    {
        jumpSpeed = 7.5f;
        moveSpeed = 5f;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Rotate(); 
    }

    private void Rotate()
    {
        transform.right = rb.velocity + Vector2.right * moveSpeed; 
    }
    private void Jump()
    {
        //rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse); 
        rb.velocity = Vector2.up * jumpSpeed;
        UponJump?.Invoke(); 
    }
    private void OnJump(InputValue inputValue)
    {
        Jump(); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        UponContact?.Invoke();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Data.CurScore++; 
        UponScore?.Invoke();    
    }
}
