using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplatforms : MonoBehaviour
{
    public Transform leftpoint,rightpoint;
    public float Speed;
    Vector3 movement;

    void Start()
    {
        movement.x = Speed;
        transform.DetachChildren();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement(){
        transform.position += movement * Time.deltaTime;
        print(transform.localScale.x);

        // transform.localScale.x = transform.localScale.x - 0.1;
        if (transform.position.x < leftpoint.position.x)
        {
            transform.localScale = new Vector3(transform.localScale.x+0.3f,transform.localScale.y,transform.localScale.z);

            // if(transform.localScale.x<=0.7&&transform.localScale.x>0.1){
            //     transform.localScale = new Vector3(transform.localScale.x-0.5f,transform.localScale.y,transform.localScale.z);
            // }else
            // {
            // }
       
            movement.x = Speed;
        }else if(transform.position.x>rightpoint.position.x)
        {
            movement.x = -Speed;
            transform.localScale = new Vector3(transform.localScale.x-0.3f,transform.localScale.y,transform.localScale.z);

        }

    }

}
