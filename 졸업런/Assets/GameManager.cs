using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] NumberImage;
    public Sprite[] Number;

    public Image TimeBar;//타임바

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
            }
        }
    }
}
