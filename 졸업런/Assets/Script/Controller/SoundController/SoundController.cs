using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource musicPlayer;
    public AudioClip Music;
    public bool off = false;
    public bool isloop = false;
    // Start is called before the first frame update
    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
        
    }
    private void Awake()
    {
        playSound(Music, musicPlayer, isloop);
    }

    // Update is called once per frame
    void Update()
    {
        if (off == true)
        {
            musicPlayer.Stop();
        }

    }
    public static void playSound(AudioClip clip, AudioSource audioPlayer,bool isloop)
    {
        audioPlayer.clip = clip;
        audioPlayer.loop = isloop;
        audioPlayer.time = 0;
        audioPlayer.Play();
    }
    public void offsound()
    {
        musicPlayer.Stop();
    }
}
