using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class UI_ChatScript : MonoBehaviour
{
    public GameObject spawner;
    public GameObject _owner;
    public Text chatText; //텍스트가 출력되는 부분
    public Text CharacterName;
    public VideoPlayer vp;
    public GameObject ts;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        vp.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (vp.time >= vp.clip.length|| Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
        {
            vp.Stop();
            ts.SetActive(true);
            StartCoroutine(TextPractice());
        }

        //_owner.SetActive(true);
    }
    
    IEnumerator Update_Text(string narration, string narrator)
    {
        string writerText = "";
        bool isButtonClicked = false;

        CharacterName.text = narrator;
        for (int i = 0; i < narration.Length; i++)
        {
            //글자 한글자 한글자 출력되게 
            writerText += narration[i];
            chatText.text = writerText;
            yield return null;

            if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
            {
                //스페이스나 엔터 누르면 스킵되게
                isButtonClicked = true;
                break;
            }
        }
            while (true)
            {

            if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
            {
                //스페이스나 엔터 누르면 스킵되게
                isButtonClicked = true;
                break;
            }

            if (isButtonClicked)
            {
                isButtonClicked = false;
                break;
            }
            yield return null;
        }
        
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(Update_Text("그동안 열심히 했군요 학생.", "교수님"));
        yield return StartCoroutine(Update_Text("이렇게 된거 제 연구실로 오시는건 어떻습니까?", "교수님"));
        spawner.SetActive(true);
        _owner.SetActive(false);

        Time.timeScale = 1;

    }
}
