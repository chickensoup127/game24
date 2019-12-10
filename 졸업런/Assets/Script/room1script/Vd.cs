using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Vd : MonoBehaviour
{
    public VideoPlayer vp;
    public GameObject obj;
    public Canvas Score;
    public bool PlayerDie = false;

    void Start()
    {
        PlayerDie = false;
    }
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

        if (PlayerDie == false)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                PlayerDie = true; ;
                vp.Stop();
                Time.timeScale = 1;
                obj.SetActive(true);
                SoundManager.Instance.PlaySound("BG");
                Score.enabled = true;
            }
        }
    }
}
