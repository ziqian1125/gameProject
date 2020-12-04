using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscenesound : MonoBehaviour
{
    // Start is called before the first frame update
    protected AudioSource backAudio;

    void Start()
    {
        backAudio = GetComponent<AudioSource>();
        // backAudio.play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
