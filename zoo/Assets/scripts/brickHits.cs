using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickHits : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Player is hit with brick!");
    }
}
