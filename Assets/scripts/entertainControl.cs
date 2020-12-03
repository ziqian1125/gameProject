using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class entertainControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Text entertain; 
    private int entertainNum;
    private int counttime=0;
    public Transform leftpoint,rightpoint;
    public Transform left1,right1;
    public Transform left2,right2;

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
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

            }

        if (Input.GetKeyUp(KeyCode.C))
            {
                entertainNum=int.Parse(entertain.text)-1;
                entertain.text = entertainNum.ToString();
            }  

        if( leftpoint.position.x<transform.position.x&&transform.position.x<rightpoint.position.x)
        {
            if(Input.GetKeyUp(KeyCode.E)){
                entertainNum=int.Parse(entertain.text) + 1;
                entertain.text = entertainNum.ToString();
                SoundManagerScript.PlaySound("clap");               
            }
        }


        if( left1.position.x<transform.position.x&&transform.position.x<right1.position.x)
        {
            if(Input.GetKeyUp(KeyCode.E)){
                entertainNum=int.Parse(entertain.text) + 1;
                entertain.text = entertainNum.ToString();
                SoundManagerScript.PlaySound("clap");               
            }
        }

        if( left2.position.x<transform.position.x&&transform.position.x<right2.position.x)
        {
            if(Input.GetKeyUp(KeyCode.E)){
                entertainNum=int.Parse(entertain.text) + 1;
                entertain.text = entertainNum.ToString();
                SoundManagerScript.PlaySound("clap");               
            }
        }

    }


    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "pole")
        {
            if (Input.GetKey(KeyCode.E))
                {
                    entertainNum=int.Parse(entertain.text)+1;
                    entertain.text = entertainNum.ToString(); 
                    //KEY PRESSED AND HELD DOWN
                }
        } 
        
        if (collision.tag == "trap") //if player runs into trap
        {
            entertainNum = int.Parse(entertain.text) + 1;
            entertain.text = entertainNum.ToString();
        }
        
        if (collision.tag == "brick") //if player is hit with brick
        {
            entertainNum = int.Parse(entertain.text) + 1;
            entertain.text = entertainNum.ToString();
        }
    }


}
