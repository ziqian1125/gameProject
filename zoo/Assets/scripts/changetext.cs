using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class changetext : MonoBehaviour
{
    // Start is called before the first frame update

    Text myText;
    Text buttonText;

    public void change()
    {
        print("change text");
        buttonText = GameObject.Find("buttonText").GetComponent<Text>(); 
        myText= GameObject.Find("mainText").GetComponent<Text>(); 
 
        // buttonText.text = "previous";
        if(buttonText.text == "next"){
           buttonText.text = "previous";
           myText.text =
        " 18,000 times less – such space has a polar bear, lion or tiger in captivity if compared with the free conditions. 5,000 – this is a number of zoo animals which are killed each year (in Europe only) Today, around 1 million vertebrate animals live in captivity worldwide. According to PETA, many of them suffer from depression and anxiety. These facilities put profits first and animal rights second. Awareness needs to be spread if we want any positive changes to occur. Source: https://petpedia.co/animals-in-captivity-statistics/";
        }else
        {
            buttonText.text = "next";    
            myText.text =
        "Most people like going to the zoo, circus or aquariums, especially with the kids. We think that these facilities are entertaining, educational and exist with the best interest of animals in mind. However, animals in captivity statistics hide the harsh truth about the environment and treatment of captive animals. And here are some numbers. 96 % – it is a chance that an elephant is treated poorly in the zoo. 75 % – it is the number of animal abuse in the world zoos and aquariums. 30 % – it is the number of aquariums and zoos that make animals perform in front of people.";          
        }
    }


    public void restart(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void healthrestart(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void happyrestart(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void timerestart(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void quit(){
        Application.Quit();
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
