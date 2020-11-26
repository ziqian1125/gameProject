using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioClip fireworkSound,coinSound,clapSound;
    static AudioSource audioSrc;

    void Start()
    {
        fireworkSound = Resources.Load<AudioClip>("fireworks");
        coinSound = Resources.Load<AudioClip>("coins");
        clapSound = Resources.Load<AudioClip>("clap");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip){
        switch (clip)
        {
            case "fireworks":
            audioSrc.PlayOneShot(fireworkSound);
                break;
            case "coins":
            audioSrc.PlayOneShot(coinSound);
                break;
            case "clap":
            audioSrc.PlayOneShot(clapSound);
                break;                   
        }
        
    }
}
