using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private float turnSpeed = 10f;

    private Rigidbody rb;
    private bool isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        HandleMovementInput();
        HandleJumpInput();
        HandleRotationInput();
    }

    private void HandleMovementInput()
    {
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = transform.forward * moveVertical;

        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

    private void HandleJumpInput()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void HandleRotationInput()
    {
        float turnHorizontal = Input.GetAxisRaw("Horizontal");

        if (turnHorizontal != 0f)
        {
            transform.Rotate(Vector3.up, turnHorizontal * turnSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
