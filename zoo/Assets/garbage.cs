using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class garbage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "garbage"){
            print("l jump on garbage");
        }
    } 

}
