using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class trap : MonoBehaviour
{
    // Start is called before the first frame update
    public int healthNum;
    public Text health; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "trap"){
            print("l jump on trap");
            healthNum=int.Parse(health.text)-1;
            health.text = healthNum.ToString();  
        }
    } 
}
