using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgsound : MonoBehaviour
{
    // protected AudioSource bgAudio;

    // Start is called before the first frame update
    void Start()
    {
 
         SoundManagerScript.PlaySound("Background");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
