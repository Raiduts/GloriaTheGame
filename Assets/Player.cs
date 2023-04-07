using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public SpriteRenderer sprite;
    [SerializeField] private AudioSource jumpSoundEffect;
    [SerializeField] private AudioSource woodSoundEffect;
    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource teleportSoundEffect;
    [SerializeField] private AudioSource damagedSoundEffect;
    


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

    void Death()
    {
        if (Data.health <= 0)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
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
            jumpSoundEffect.Play();
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
        if (other.tag == "WoodToken")
        {
            Destroy(other.gameObject);
            woodSoundEffect.Play();
        }
        else if (other.tag == "FallDetector")
        {
            transform.position = respawnPoint;
            rb.velocity = new Vector2(0, 0);
            Data.health--;
            teleportSoundEffect.Play();
        }
        else if (other.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }else if (other.tag == "Obstacle")
        { 
            StartCoroutine(FlashDamage());
            damagedSoundEffect.Play();
        }
    }

    public IEnumerator FlashDamage()
    {
        sprite.color = Color.red;
        Data.health--;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
    }
}
