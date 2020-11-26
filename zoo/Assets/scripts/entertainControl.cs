using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class entertainControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Text entertain; 
    private int entertainNum;
    private int counttime=0;



    void Start()
    {
        entertain.text = "3";
        InvokeRepeating("countTime", .0f, 1f);

    }

    void countTime()
    {
        if (counttime!=15)
        {
            counttime = counttime+1;
            // print(counttime);
        }else{
            counttime = 0;
            
            if(entertain.text=="0"){
                entertain.text="0";
            }else{
              entertainNum=int.Parse(entertain.text)-1;
              entertain.text = entertainNum.ToString();                
            }

        }
    //    print("hihihi");
    }

    // Update is called once per frame
    void Update()
    {
        // print(Mathf.FloorToInt(Time.time));

   

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
