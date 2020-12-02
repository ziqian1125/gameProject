using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstSceneMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManagerScript.PlaySound("Background");
        print("play sound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
