using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Yogini's Script
public class SuccessPlayerMove : MonoBehaviour
{
    // declaring variable
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        // accessing rigidbody component   
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //having the player go up the rope in the "winning" scene
        rb.velocity = transform.up * 2f;
    }
}
