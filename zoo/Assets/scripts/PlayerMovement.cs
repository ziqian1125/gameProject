﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private Animator charAnim;
    private float moveSpeed;
    private float runSpeed;
    private float jumpSpeed;
    private float climbSpeed;
    private int jumpcount;

    // idle = 0, walking = 1, jumping = 2 , etc
    public enum State {idle, walking, jumping, falling, running, dancing, climbing, hiding};
    public State animState = State.idle;
    private Collider2D coll;
    [SerializeField] private LayerMask ground;
    

    public GameObject Ebutton;
    public GameObject Cbutton;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        charAnim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();

        moveSpeed = 3f;
        runSpeed = 8f;
        jumpSpeed = 6f;
        climbSpeed = 3f;
        jumpcount = 0;

        Ebutton.SetActive(false);
        Cbutton.SetActive(false);
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
        else if (Input.GetKey(KeyCode.E) && Ebutton.active)
        {
            //Test
            //Debug.Log("Detected");
            animState = State.dancing;
            moveSpeed = 0f;

        }
        else if (Input.GetKey(KeyCode.F) && Cbutton.active)
        {
            //Test
            //Debug.Log("Detected");
            animState = State.climbing;
            rb.velocity = transform.up * climbSpeed;
            moveSpeed = 0f;


        }

        else if (Input.GetKey(KeyCode.C))
        {
            //Test
            //Debug.Log("Detected");
            animState = State.hiding;
            moveSpeed = 0f;
    
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
       

       if (Input.GetButtonDown("Jump") && jumpcount<1)
            {
             jumpcount++;
             rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
             animState = State.jumping; 
        }

        if (coll.IsTouchingLayers(ground))
        {
            jumpcount = 0;
            //Test
            //Debug.Log("Jumpcount is" + jumpcount);
        }



        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;
        }

        else
        {
            moveSpeed = 3f;
        }

      


    }

    private void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.gameObject.tag == "pole")
        {   //Test
            // Debug.Log("Hit");
            Ebutton.SetActive(true);
        }
        if (Collider.gameObject.tag == "rope")
        {   //Test
            // Debug.Log("Hit");
            Cbutton.SetActive(true);
        }

            
        
    }

    private void OnTriggerExit2D(Collider2D Collider)
    {
        if (Collider.gameObject.tag == "pole")
        {
            //Test
            // Debug.Log("Hit");
            Ebutton.SetActive(false);
        }
        if (Collider.gameObject.tag == "rope")
        {
            //Test
            // Debug.Log("Hit");
            Cbutton.SetActive(false);
        }

    }

   

}
