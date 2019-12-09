using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class UI_GameOver : MonoBehaviour
{
    public VideoPlayer vp,vp_thrall;
    public GameObject bt1, bt2;
    public GameObject thrall;
    private void Awake()
    {
        vp.Play();
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
            bt1.SetActive(true);
            bt2.SetActive(true);

        }
        if (vp_thrall.time >= vp.clip.length)
        {
            bt1.SetActive(true);
        }
    }

    public void BtnClickRestart()
    {
        SceneManager.LoadScene("room3");
        //씬 재시작 로직 실행
    }
    public void BtnClickGameOver()
    {
        bt1.SetActive(false);
        bt2.SetActive(false);

        vp.Stop();
        thrall.SetActive(true);
        vp_thrall.Play();
    }

}
