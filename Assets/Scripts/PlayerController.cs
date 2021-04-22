using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private bool facingRight = true;

    public float jumpForce;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    public bool playerRun = true;

    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        if (playerRun == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                extraJumps--;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
            {
                rb.velocity = Vector2.up * jumpForce;
            }
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        if(playerRun == true)
        {
            float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed; // movement horizontal controller
            transform.position += new Vector3(xValue, 0, 0); // add change the 2nd "0" to "yValue" for Vertical

            //Flips the character horizontally
            if (facingRight == false && xValue > 0)
            {
                Flip();
            }
            else if (facingRight == true && xValue < 0)
            {
                Flip();
            }
        }
    }

    void Flip() //Function for inverting player sprite horizontally
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
