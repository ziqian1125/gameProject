using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioClip fireworkSound,coinSound,clapSound,BackgroundSound,RunSound,WalkSound,ButtonSound;
    static AudioSource audioSrc;

    void Start()
    {

        BackgroundSound = Resources.Load<AudioClip> ("Background");
        fireworkSound = Resources.Load<AudioClip>("fireworks");
        coinSound = Resources.Load<AudioClip>("coins");
        clapSound = Resources.Load<AudioClip>("clap");
        RunSound = Resources.Load<AudioClip> ("Run");
        WalkSound = Resources.Load<AudioClip> ("Walk");
        ButtonSound = Resources.Load<AudioClip> ("Button");


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
            case "Background":
            audioSrc.PlayOneShot(BackgroundSound);
                break;
            case "Run":
                audioSrc.PlayOneShot(RunSound);
                break;
            case "Walk":
                audioSrc.PlayOneShot(WalkSound);
                break;
             case "Button":
                audioSrc.PlayOneShot(ButtonSound);
                break;           
        }
        
    }
}
