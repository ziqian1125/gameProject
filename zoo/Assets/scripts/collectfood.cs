﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectfood : MonoBehaviour
{
    // Start is called before the first frame update
    public int Cherry = 1;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Collection")
        {
            Destroy(collision.gameObject);
            Cherry +=1;
        }
        
    } 
}
