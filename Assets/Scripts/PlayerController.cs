using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 10.0f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float reflectionXOffset = 0.5f; 

    private Rigidbody2D rb;
    private bool isGrounded;
    private float groundCheckRadius = 0.2f;
    private InputWrapper _inputWrapper;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _inputWrapper = new InputWrapper();
    }

    void Update()
    {
        Move();
        Jump();
    }
    
    public float GetHorizontalSpeed()
    {
        return rb.velocity.x;
    }

    public bool IsJumping()
    {
        return !isGrounded;
    }

    void Move()
    {
        float horizontalInput = _inputWrapper.HorizontalInput;
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }

    void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (_inputWrapper.JumpInput && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}