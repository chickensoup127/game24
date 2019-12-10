using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Succes_Video : MonoBehaviour
{
    public VideoPlayer vp;


    private void Awake()
    {
        Time.timeScale = 0;
        vp.Prepare();
        vp.Play();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (vp.time >= vp.clip.length)
        {
            vp.Stop();
            Time.timeScale = 0;
            SoundManager.Instance.StopSound("BG");
        }
    }
}