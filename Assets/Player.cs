using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float walk;
    public float sprint;
    private float speed;
    private float directionInput;
    public float jumpForce;
    public LayerMask ground;

    private bool isGround;
    public Transform feet;
    public float radius;

    public float airTime;
    private float airTimeCounter;
    private bool isJumping;

    private Vector3 respawnPoint;
    public GameObject fallDetector;


     
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        directionInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift))
             
        {
            speed = sprint;
        }
        else
        {
            speed = walk;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = walk;
        }
        FaceDirection();
        Jump();
        Death();
        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);
    }

    void Death(){
        if (Data.health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(directionInput * speed, rb.velocity.y);
    }

    void FaceDirection()
    {
        if (directionInput > 0)
        {
            transform.localScale = new Vector2(1 * 1, 1);
        }

        if (directionInput < 0)
        {
            transform.localScale = new Vector2(1 * -1, 1);
        }
    }

    void Jump()
    {
        isGround = Physics2D.OverlapCircle(feet.position, radius, ground);

        if (isGround == true && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            airTimeCounter = airTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetButton("Jump") && isJumping == true)
        {
            if (airTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                airTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("WoodToken"))
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "FallDetector")
        {
            transform.position = respawnPoint;
        }
    }
}
