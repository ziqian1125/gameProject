using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update


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
            if(transform.localScale.x<=0.7&&transform.localScale.x>0.1){
                transform.localScale = new Vector3(transform.localScale.x-0.1f,transform.localScale.y,transform.localScale.z);
            }else
            {
                                transform.localScale = new Vector3(transform.localScale.x+0.6f,transform.localScale.y,transform.localScale.z);
            }
       
            movement.x = Speed;
        }else if(transform.position.x>rightpoint.position.x)
        {
            movement.x = -Speed;
        }

    }


}
