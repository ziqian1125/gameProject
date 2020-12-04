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
        //Increase stamina over time
        InvokeRepeating("countTime", .0f, 1f);

        //don't show 'out of stamina' message on start
        NoStamina = GameObject.Find("NoStamina");
        NoStamina.SetActive(false);
    }

    // Update is called once per frame
    void Update()

    {
        if (stamina.text == "0")
        {
            //show message if stamina is depleted
            NoStamina.SetActive(true);
        }
        else
        {
            //don't show message if there is some stamina
            NoStamina.SetActive(false);
        }

        //reduce stamina when character runs, climbs, dances
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.E))
        {
            if (stamina.text != "0")
            {
                staminaNum = int.Parse(stamina.text) - 1;
                stamina.text = staminaNum.ToString();
            }
        }

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

            //increase stamina over time if not full
            if (int.Parse(stamina.text) < 3)
            {
                staminaNum = int.Parse(stamina.text) + 1;
                stamina.text = staminaNum.ToString();
            }

        }
    }
}