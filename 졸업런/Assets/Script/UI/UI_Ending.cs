using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class UI_Ending : MonoBehaviour
{
    public VideoPlayer vp;
    public GameObject bt;

    // Start is called before the first frame update
    private void Awake()
    {
        vp.Prepare();        
        Debug.Log("동영상이 준비가 끝났습니다.");

        vp.Play();

        Debug.Log("동영상이 재생됩니다.");
    }
    void Start()
    {


    }
    private void OnEnable()
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
}
