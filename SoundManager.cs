using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    //dilwnw ta audio clips kai audio sources opws emfanizontai sto unity
    public AudioSource coinsound;
    public AudioClip coin_collect;

    public AudioSource flapsource;
    public AudioClip flap;

    public AudioSource GameOverSource;
    public AudioClip Game_over;

    public AudioSource Background_source;
    public AudioClip background;
    private void Awake()
    {
        instance = this; 
    }

    void Start()
    {
        //thetw ta audio Sources
       
        Background_source = GetComponent<AudioSource>();

        coinsound = GetComponent<AudioSource>();

        flapsource = GetComponent<AudioSource>();

        GameOverSource = GetComponent<AudioSource>();
    }

    
}
