using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class entertainControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Text entertain; 
    private int entertainNum;


    void Start()
    {
        entertain.text = "3";

    }

    // Update is called once per frame
    void Update()
    {
        if (entertain.text=="0")
            {
            print("catch"); 
            }

        if (Input.GetKeyUp(KeyCode.C))
            {
                entertainNum=int.Parse(entertain.text)-1;
                entertain.text = entertainNum.ToString();
            }  
        
        
    }
}
