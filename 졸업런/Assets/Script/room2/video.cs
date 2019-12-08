using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class video : MonoBehaviour
{
    public VideoPlayer vp;
  
    private void Awake()
    {
        vp.Play();
        Time.timeScale = 0;
       
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (vp.time >= vp.clip.length)
        {
            vp.Stop();
            Time.timeScale = 1;
        }

    }

   


}