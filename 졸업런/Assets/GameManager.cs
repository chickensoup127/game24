using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] NumberImage;
    public Sprite[] Number;

    public Image TimeBar;//타임바
    
    public GameObject EndPanel;//엔드판넬 변수

    public GameObject SuccessPanel;//성공판넬 변수

    public void Restart_Btu()
    {
        DataManager.Instance.score = 0;
        DataManager.Instance.PlayerDie = false;
        DataManager.Instance.Success = false;
        DataManager.Instance.playTimeCurrent = DataManager.Instance.playTimeMax;

        Time.timeScale = 1;

        SceneManager.LoadScene("room1");
    }
    

    private void Update()
    {
        //점수 100단위
        int temp = DataManager.Instance.score / 100;
        NumberImage[0].GetComponent<Image>().sprite = Number[temp];
        //10단위0-99
        int temp2 = DataManager.Instance.score % 100;
        //0-9
        temp2 = temp2 / 10;
        NumberImage[1].GetComponent<Image>().sprite = Number[temp2];
        //1단위
        int temp3 = DataManager.Instance.score % 10;
        NumberImage[2].GetComponent<Image>().sprite = Number[temp3];

        if (!DataManager.Instance.PlayerDie)
        {
            DataManager.Instance.playTimeCurrent -= 1 * Time.deltaTime; //1초에 1씩 감소
            //시간오버되면 죽음

            TimeBar.fillAmount = DataManager.Instance.playTimeCurrent / DataManager.Instance.playTimeMax;

            if (DataManager.Instance.playTimeCurrent < 0)
            {
                DataManager.Instance.PlayerDie = true;//배경끄기
                Time.timeScale = 0;
            }

        }
        
        if (DataManager.Instance.PlayerDie == true)//플레이어 죽으면 엔드판넬 켜기
        {
            EndPanel.SetActive(true);
        }

        if (DataManager.Instance.Success == true)//성공하면 성공판넬 켜기
        {
            SuccessPanel.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
}
