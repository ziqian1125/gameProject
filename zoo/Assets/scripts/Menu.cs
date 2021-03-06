﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {      
        SoundManagerScript.PlaySound("Button");
        InvokeRepeating("LoadScene", 2.0f, 0.3f);
    }

    public void rules()
    {      
        SoundManagerScript.PlaySound("Button");
        InvokeRepeating("goRules", 2.0f, 0.3f);
    }  

    public void LoadScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void goRules(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void quit(){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
