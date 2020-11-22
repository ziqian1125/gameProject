using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Text health;
    private int healthNum;
 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (health.text=="0")
        {
           print("die"); 
        }

    if (Input.GetKeyUp(KeyCode.V))
        {
            healthNum=int.Parse(health.text)-1;
            health.text = healthNum.ToString();
        }  
    }

 
}
