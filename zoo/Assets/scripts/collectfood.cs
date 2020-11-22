using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectfood : MonoBehaviour
{
    // Start is called before the first frame update
    public int Cherry = 1;
    public Text health; 


    void Start()
    {
        health.text = "3";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Collection")
        {
            Destroy(collision.gameObject);
            Cherry += 1;
            health.text = (3+Cherry).ToString();
        }
    } 
}
