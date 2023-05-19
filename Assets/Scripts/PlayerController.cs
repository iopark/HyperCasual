using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    //Reflection: following controller attempts to focus solely upon 'controller', taking input. 
    // this does not account for other things except for rigidbody, which is directly affecting model itself. 
    // the functionality is isolated thanks to event, could possibly say this is implementing observer pattern: only helping MVC model. 
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;

    public UnityEvent UponJump;     // Connecting view apart from the controller using event method/ 
    public UnityEvent UponContact; 
    public UnityEvent UponScore; 

    private void Awake()
    {                                        //This is probably 'facade'-able. 
        jumpSpeed = 7.5f;                    //
        moveSpeed = 5f;                      //
        rb = GetComponent<Rigidbody2D>();    //
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
        GameManager.Data.CurScore++; // Calls out both Current, and BestScore 
        UponScore?.Invoke();    
    }
}
