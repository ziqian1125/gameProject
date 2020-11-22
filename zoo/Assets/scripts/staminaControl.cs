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

        if (Input.GetKeyUp(KeyCode.X))
        {
            // print("hello world");
            print(stamina.text.GetType());
            staminaNum=int.Parse(stamina.text)-1;
            stamina.text = staminaNum.ToString();


            //do stuff
        }       
        
    }
}
