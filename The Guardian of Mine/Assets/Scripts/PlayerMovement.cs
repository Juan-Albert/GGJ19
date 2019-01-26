using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    [Header("Movement")]
    private Rigidbody _rB;
    public float moveSpeed;
    public bool movement;
    public int sensitiveX;

    [Header("Jump")]
    public bool canJump;
    public float jumpForce;

    [Header("Ground")]
    public Transform groundCheck;
    public Transform reSpawn;
    public LayerMask whatIsGround;

    private bool _grounded;
    private bool _jumpKeyPressed;

    void Start()
    {
        _rB = GetComponent<Rigidbody>();
        Cursor.visible = false;
    }

    void Update()
    {
        if (movement)
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitiveX, 0);
    }

    void FixedUpdate()
    {
        if (movement)
        {
            handleInput();
        }

        if (canJump)
        {
            CheckJump();
        }

        
    }

    private void handleInput()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 despH = transform.right * moveSpeed * h * Time.deltaTime;
        Vector3 despV = transform.forward * moveSpeed * v * Time.deltaTime;

        _rB.MovePosition(_rB.position + despV + despH);
    }

    private void CheckJump()
    {
        if (groundCheck != null)
        {
            _grounded = Physics.OverlapSphere(groundCheck.position, 0.01f, whatIsGround).Length > 0;
        }

        if (_grounded  && Input.GetKeyDown(KeyCode.Space) && _jumpKeyPressed == false)
        {
            _jumpKeyPressed = true;
            _grounded = false;
            _rB.AddForce(Vector3.up * jumpForce);
        }

        if (!Input.GetKeyDown(KeyCode.Space) && _jumpKeyPressed == true)
        {
            _jumpKeyPressed = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.layer);

        if (collision.gameObject.layer == 10)
        {
            Debug.Log("Holi");
            this.gameObject.transform.position = reSpawn.position;

        }
    }
}
