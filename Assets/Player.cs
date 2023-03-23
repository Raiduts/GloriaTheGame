using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float ms;
    public float jumpForce;
    public LayerMask ground;
    public LayerMask lift;
     
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");


        if (Input.GetKey(KeyCode.LeftShift))
        {    

            rb.velocity = new Vector2((ms * 2) * horiz , rb.velocity.y);
           
        }
        else
        {
            rb.velocity = new Vector2(ms * horiz , rb.velocity.y);    
           
        }


        if (Input.GetButtonDown("Jump") && isGround())
        {  
            rb.AddForce(new Vector2(0, jumpForce));
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

    bool isGround(){
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.1f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, ground);
        if (hit.collider != null)
        {
            return true;
        }
        return false;

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
