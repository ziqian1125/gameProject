using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickHits : MonoBehaviour
{

    //If brick hits a player who is not hiding, it will reduce health
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && GameObject.Find("Player").GetComponent<PlayerMovement>().animState != PlayerMovement.State.hiding)
        {
            Debug.Log("Player is hit with brick!");
            GameObject.Find("Player").GetComponent<healthControl>().healthReduce();
        }
    }
}
