using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Ebutton;
    private Rigidbody2D rb;
    private Animator charAnim;
    [SerializeField] private float moveSpeed;
    public float runSpeed;
    [SerializeField] private float jumpSpeed;
    // idle = 0, walking = 1, jumping = 2 , etc
    private enum State {idle, walking, jumping, falling, running, dancing};
    private State animState = State.idle;
    private Collider2D coll;
    [SerializeField] private LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        charAnim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();

        moveSpeed = 2f;
        runSpeed = 4f;
        Ebutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        AnimationState();
        charAnim.SetInteger("state", (int)animState);
    }

    private void AnimationState()
    {
        if(animState == State.jumping)
        {
            if(rb.velocity.y < -0.5f)
            {
                animState = State.falling;
            }
        }

      else if (animState == State.falling)
        {
            if(coll.IsTouchingLayers(ground))
            {
                animState = State.idle;
            }
        }
       
        else if (Mathf.Abs(rb.velocity.x) > 1.8f)
        {
            if (Mathf.Abs(rb.velocity.x) > 3f)
             {
                 //running
                 animState = State.running;
             }

             else
             {
            //moving
            animState = State.walking;
          }
        }

      

        else
        {
            animState = State.idle;
        }

    }   

    private void Movement()
    {
        //Player Input for for movement
        float horDir = Input.GetAxis("Horizontal");
 
        //direction
        if (horDir < 0)
        { //left
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-0.4f, 0.4f);
        }

        else if (horDir > 0)
        {
            //right
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(0.4f, 0.4f);
        }

        if (Input.GetButtonDown("Jump") && coll.IsTouchingLayers(ground))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            animState = State.jumping;
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;
        }

        else
        {
            moveSpeed = 2f;
        }

        if(Input.GetKeyDown(KeyCode.E) && Ebutton.active)
        {
            // Debug.Log("Detected");
            animState = State.dancing;
        }

      
    }

    private void OnTriggerEnter2D(Collider2D Collider)
    {
        // Debug.Log("Hit");
        Ebutton.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D Collider)
    {
        // Debug.Log("Hit");
        Ebutton.SetActive(false);
    }

}
