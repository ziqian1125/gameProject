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

    void Start()
    {
        InvokeRepeating("countTime", .0f, 1f);
    }

    // Update is called once per frame
    void Update()

    {
        //StartCoroutine(IncreaseStamina());

        if (stamina.text=="0")
        {
           print("out of stamina");
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) ||Input.GetKeyUp(KeyCode.F))
        {
            if (stamina.text!="0")
            {
                print("stamina is depleted "); 
                // print(stamina.text.GetType());
                staminaNum=int.Parse(stamina.text)-1;
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

            if (int.Parse(stamina.text) < 3)
            {
                staminaNum = int.Parse(stamina.text) + 1;
                stamina.text = staminaNum.ToString();
            }

        }
    }

    /*public IEnumerator IncreaseStamina()
    {
        yield return new WaitForSeconds(5f);
        //staminaNum = int.Parse(stamina.text) + 1;
        //stamina.text = staminaNum.ToString();
        
    }*/
}
