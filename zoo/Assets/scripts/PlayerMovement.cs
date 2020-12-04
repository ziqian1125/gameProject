using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Yogini's Script

public class PlayerMovement : MonoBehaviour
{
    //declaring variables to access components of player gameobject
    private Rigidbody2D rb;
    private Animator charAnim;
    private Collider2D coll;
    
    //declaring variables for movement
    private float moveSpeed;
    private float runSpeed;
    private float jumpSpeed;
    private float climbSpeed;
    private int jumpcount;

    //declaring enumerations to change animation states
    public enum State {idle, walking, jumping, falling, running, dancing, climbing, hiding};
    public State animState = State.idle;
   
    // declaring Layer to detect collisions with horizontal surfaces so as to control jumps
    [SerializeField] private LayerMask ground;
    
    //declaring variables for in-game instructions
    public GameObject Ebutton;
    public GameObject Cbutton;
    
    // Start is called before the first frame update
    void Start()
    {
        // accessing components
        rb = GetComponent<Rigidbody2D>();
        charAnim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
        
        // assigning initial values
        moveSpeed = 3f;
        runSpeed = 8f;
        jumpSpeed = 6f;
        climbSpeed = 3f;
        jumpcount = 0;
        
        // making buttons invisible
        Ebutton.SetActive(false);
        Cbutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // calling functions for movement, change of state and passing the proper integer for state change
        Movement();
        AnimationState();
        charAnim.SetInteger("state", (int)animState);
    }

    // fucntion for most changes in character animations
    private void AnimationState()
    {
        //for falling animation
        if(animState == State.jumping)
        {
            if(rb.velocity.y < -0.5f)
            {
                animState = State.falling;
            }
        }
        
        //for character to go back to idle when it hits a horizontal surface
        else if (animState == State.falling)
        {
            if(coll.IsTouchingLayers(ground))
            {
                animState = State.idle;
            }
        }
       
        // if velocity > 0, character switches from idle to either running or walking states, depending on its velocity
        else if (Mathf.Abs(rb.velocity.x) > 0f)
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
        
        //if player holds down E button when the Instruction UI element is made visible in the entertainment area and the stamina bar is not equal to zero,
        //the player entertains the audience and the entertainment bar goes up.
        else if (Input.GetKey(KeyCode.E) && Ebutton.active && GetComponent<staminaControl>().stamina.text != "0")
        {
            animState = State.dancing;
            moveSpeed = 0f;
        }
        
        //if player holds down F button when the Instruction UI element is made visible at the rope, and the stamina bar is not equal to zero,
        //the player climbs up automatically
        else if (Input.GetKey(KeyCode.F) && Cbutton.active && GetComponent<staminaControl>().stamina.text != "0")
        {
            animState = State.climbing;
            rb.velocity = transform.up * climbSpeed;
            moveSpeed = 0f;
        }

        // if player holds C, the character crouches for protection
        else if (Input.GetKey(KeyCode.C))
        {
            animState = State.hiding;
            moveSpeed = 0f;
        }
        
        // if there's no user input, the idle animation plays
        else
        {
            animState = State.idle;
        }
    }   

    // function for movement
    private void Movement()
    {
        //Player Input for for movement
        float horDir = Input.GetAxis("Horizontal");
 
        //direction
        if (horDir < 0)
        { 
            //left
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-0.4f, 0.4f);
        }

        else if (horDir > 0)
        {
            //right
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(0.4f, 0.4f);
        }
       
       // when the spacebar is pressed and the character has not double jumped already, the character gets to jump
       if (Input.GetButtonDown("Jump") && jumpcount<1)
        {
            jumpcount++;
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            animState = State.jumping; 
        }
        
        // resetting the jump count as the character touches the ground, so as to enable the player to double jump again
        if (coll.IsTouchingLayers(ground))
        {
            jumpcount = 0;
        }

        // Left shift to increase the speed for running animation to be activated
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;
        }

        // speed kept low for the character to walk
        else
        {
            moveSpeed = 3f;
        }
    }
    
    // functions to detect triggers for UI instructions to be made
   
    //visible
    private void OnTriggerEnter2D(Collider2D Collider)
    {
        //for entertainment
        if (Collider.gameObject.tag == "pole")
        {   
            Ebutton.SetActive(true);
        }
        
        //for climbing
        if (Collider.gameObject.tag == "rope")
        {  
            Cbutton.SetActive(true);
        }   
    }

    //invisible
    private void OnTriggerExit2D(Collider2D Collider)
    {
        // for entertainment
        if (Collider.gameObject.tag == "pole")
        {
            Ebutton.SetActive(false);
        }
        
        // for climbing
        if (Collider.gameObject.tag == "rope")
        {
            Cbutton.SetActive(false);
        }

    }
}
