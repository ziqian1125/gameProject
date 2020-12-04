using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class staminaControl : MonoBehaviour
{
    // Start is called before the first frame update
    public int staminaNum;
    public Text stamina;
    private int counttime = 0;
    public GameObject NoStamina;

    void Start()
    {
        InvokeRepeating("countTime", .0f, 1f);
        NoStamina = GameObject.Find("NoStamina");
        NoStamina.SetActive(false);
    }

    // Update is called once per frame
    void Update()

    {
        if (stamina.text == "0")
        {
            NoStamina.SetActive(true);
        }
        else
        {
            NoStamina.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.E))
        {
            if (stamina.text != "0")
            {
                staminaNum = int.Parse(stamina.text) - 1;
                stamina.text = staminaNum.ToString();
            }
        }

        // if (Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D))
        // {
        //     if (stamina.text!="0")
        //     {
        //       SoundManagerScript.PlaySound("clap");
        //     }
        // }      

    }
    void countTime()
    {
        if (counttime != 3)
        {
            counttime = counttime + 1;
        }
        else
        {
            counttime = 0;

            if (int.Parse(stamina.text) < 3)
            {
                staminaNum = int.Parse(stamina.text) + 1;
                stamina.text = staminaNum.ToString();
            }

        }
    }
}