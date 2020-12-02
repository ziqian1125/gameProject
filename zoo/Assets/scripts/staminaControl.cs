using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class staminaControl : MonoBehaviour
{
    // Start is called before the first frame update
    public int staminaNum;
    public Text stamina; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if (stamina.text=="0")
        {
           print("die"); 
        }

        if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.D))
        {
            if (stamina.text!="0")
            {
                print("stamina is depleted "); 
                // print(stamina.text.GetType());
                staminaNum=int.Parse(stamina.text)-1;
                stamina.text = staminaNum.ToString();
                SoundManagerScript.PlaySound("Run");
            }
            //do stuff
        } 

        if (Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D))
        {
            if (stamina.text!="0")
            {
              SoundManagerScript.PlaySound("clap");
            }
            //do stuff
        }      
        
    }
}
