using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float ms;
    public float jumpForce;
    public LayerMask lift;
    public LayerMask ground;

    private bool isGround;
    public Transform feet;
    public float radius;

    public float airTime;
    private float airTimeCounter;
    private bool isJumping;
     
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        isGround = Physics2D.OverlapCircle(feet.position, radius, ground);
        float horiz = Input.GetAxis("Horizontal");


        if (Input.GetKey(KeyCode.LeftShift))
        {    

            rb.velocity = new Vector2((ms * 2) * horiz , rb.velocity.y);
           
        }
        else
        {
            rb.velocity = new Vector2(ms * horiz , rb.velocity.y);    
           
        }


        if (isGround == true && Input.GetKeyDown(KeyCode.Space))
        {  
            isJumping = true;
            airTimeCounter = airTime;
            rb.AddForce(new Vector2(0, jumpForce));
            
        }

        if(Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if(airTimeCounter > 0){
                rb.AddForce(new Vector2(0, jumpForce));
                airTimeCounter -= Time.deltaTime;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        if (horiz > 0)
        {
            transform.localScale = new Vector2(1 * 1, 1);
        }

        if (horiz < 0)
        {
            transform.localScale = new Vector2(1 * -1, 1);
        }

        if (isLift())
        {
            LiftMerah.active = true;
        }
        else
        {
            LiftMerah.active = false;
        }

    }

    bool isLift(){
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.1f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, lift);
        if (hit.collider != null)
        {
            return true;
        }
        return false;

    }
}
