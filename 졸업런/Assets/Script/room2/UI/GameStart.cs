using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameStart : MonoBehaviour
{
    public Canvas gamestart;
    public Canvas GameOn;
    public VideoPlayer video_start;
    public Canvas Minimap;

    bool isStart = false;


    // Start is called before the first frame update
    void Start()
    {
        
            gamestart.enabled = true;
            Time.timeScale = 0;
        GameOn.enabled = false;
        video_start.Play();
        Minimap.enabled = false;
        //Sound.Instance.StopAllSound();



}

    // Update is called once per frame
    void Update()
    {
        if (isStart == false)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                isStart = true;
                Time.timeScale = 1;
                gamestart.enabled = false;
                GameOn.enabled = true;
                video_start.Stop();
                Minimap.enabled = true;
                Sound.Instance.PlaySound("bgm");

            }
        }

    }

   
}
