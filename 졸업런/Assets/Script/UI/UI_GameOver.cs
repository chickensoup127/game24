using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class UI_GameOver : MonoBehaviour
{
    public VideoPlayer vp;
    public GameObject bt;
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
            bt.SetActive(true);
        }

    }

    public void BtnClickGameOver()
    {
        SceneManager.LoadScene("room3");
        //씬 재시작 로직 실행
    }


}
