using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
 
    }

    public void healthReduce()
    {
        if (health.text!="0")
        {
           healthNum = int.Parse(health.text) - 1;
           health.text = healthNum.ToString();         
        }

    }
}
