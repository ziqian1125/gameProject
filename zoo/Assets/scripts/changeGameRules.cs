using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class changeGameRules : MonoBehaviour
{

    Text buttonText;
    Text content;

    // Start is called before the first frame update

    public void change()
    {
        buttonText = GameObject.Find("buttonText").GetComponent<Text>(); 
        content = GameObject.Find("content").GetComponent<Text>(); 

        if(buttonText.text == "next"){
           buttonText.text = "previous";
           content.text =
        "walking = A/D\nsprinting = shift + A/D\njumping = space\ndouble jump = press space twice\nclimbing = F\ninteracting with pole = E\ncrouching = C";        
        
        }else
        {
            buttonText.text = "next";    
            content.text =
        "Your caretaker has accidentally left the cage door open. This is your chance to escape! Try to make it to the top of the cage by jumping and climbing. Don’t forget to balance your stamina and keep the audience entertained at the same time. Also, watch out for those traps and falling rocks!";                      
        }

    }


    // public void back()
    // {      
    //     SoundManagerScript.PlaySound("Button");
    //     InvokeRepeating("goback", 2.0f, 0.3f);
    // }  

    public void goback(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
