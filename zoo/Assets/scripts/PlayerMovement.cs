using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator charAnim;
    public float moveSpeed;
   // public float runSpeed;
    public float jumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        charAnim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //Player Input for for movement
        float horDir = Input.GetAxis("Horizontal");

        if (horDir < 0)
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-0.5f, 0.5f);
            charAnim.SetBool("walking", true);
        }

        else if (horDir > 0)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(0.5f, 0.5f);
            charAnim.SetBool("walking", true);
        }

        else
        {
            charAnim.SetBool("walking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);

        }

        /*while (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;
        }*/
        

    }
}
