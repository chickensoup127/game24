using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Vd : MonoBehaviour
{
    public Canvas Score;
    public VideoPlayer vp;
    public GameObject obj;


    private void Awake()
    {
        Time.timeScale = 0;
        vp.Prepare();
        vp.Play();
        Score.enabled = false;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (vp.time >= vp.clip.length|| Input.GetKeyDown(KeyCode.Return))
        {
                vp.Stop();
                Time.timeScale = 1;
                obj.SetActive(true);
                Score.enabled = true;
            SoundManager.Instance.PlaySound("BG");


        }
    }
}
