using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectfood : MonoBehaviour
{
    // Start is called before the first frame update
    public int Cherry = 1;
    public int pill = 0;

    public Text health; 
    public Text stamina; 


    void Start()
    {
        health.text = "3";
        stamina.text = "3";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Collection")
        {
            SoundManagerScript.PlaySound("fireworks");
            Destroy(collision.gameObject);
            Cherry += 1;
            stamina.text = (3+Cherry).ToString();
        }else if(collision.tag == "pills")
        {
            SoundManagerScript.PlaySound("coins");
            Destroy(collision.gameObject);
            pill += 1;
            health.text = (3 + pill).ToString();
        }
    } 
}
