using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameScore : MonoBehaviour
{
    //public GameObject[] NumberImage;
    //public Sprite[] Number;

    public Image TimeBar;//타임바
    public float playTimeCurrent = 10f;
    public float playTimeMax = 10f;
    bool isDie = false;
    Text score;

    public Canvas GameOn;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
       score.text = StaticVal.gameScore.ToString();


        if (!isDie)
        {
            playTimeCurrent -= 1 * Time.deltaTime; //1초에 1씩 감소
            //시간오버되면 죽음

            TimeBar.fillAmount = playTimeCurrent / playTimeMax;


            if (playTimeCurrent < 0)
            {
                isDie = true;
                GameOn.enabled = false;

            }
        }
        
    }
}
