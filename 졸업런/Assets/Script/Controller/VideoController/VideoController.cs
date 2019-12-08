using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class VideoController : Controller
{
    public RawImage Image;
    public VideoPlayer vidio;
    public AudioSource audio;

    void Awake()

    {

        Image = GetComponent<RawImage>();

        vidio = gameObject.AddComponent<VideoPlayer>();

        audio = gameObject.AddComponent<AudioSource>();

        vidio.playOnAwake = false;

        audio.playOnAwake = false;

        audio.Pause();

        PlayVideo();

    }

    public void PlayVideo()
    {
        playVideo();
    }

    IEnumerator playVideo()
    {

        vidio.audioOutputMode = VideoAudioOutputMode.AudioSource;
        vidio.EnableAudioTrack(0, true);
        vidio.SetTargetAudioSource(0, audio);
        vidio.Prepare();

        WaitForSeconds waitTime = new WaitForSeconds(1.0f);

        while (!vidio.isPrepared)

        {

            Debug.Log("동영상 준비중...");

            yield return waitTime;

        }

        Debug.Log("동영상이 준비가 끝났습니다.");

        Image.texture = vidio.texture;

        vidio.Play();

        audio.Play();

        Debug.Log("동영상이 재생됩니다.");

        while (vidio.isPlaying)

        {

            Debug.Log("동영상 재생 시간 : " + Mathf.FloorToInt((float)vidio.time));

            yield return null;

        }

        Debug.Log("영상이 끝났습니다.");

    }
    
}
