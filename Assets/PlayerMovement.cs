using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    

    private float horizontal;
    [SerializeField] private float speed = 8f;
    [SerializeField] private float jumpForce = 8f;
    private bool isFacingRight = true;

    [SerializeField] private GameObject player;

    private void Update()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);

        if (!isFacingRight && horizontal > 0)
        {
            Flip();

            //ControllerRotation crosshairScript = player.GetComponent<ControllerRotation>();
            //crosshairScript.Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            Flip();

            //ControllerRotation crosshairScript = player.GetComponent<ControllerRotation>();
            //crosshairScript.Flip();
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        if (context.canceled && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }
    }

    public void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("Fire");
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }
}
