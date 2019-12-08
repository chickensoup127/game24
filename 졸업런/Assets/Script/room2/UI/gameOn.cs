using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOn : MonoBehaviour
{

    public static float distractionCurrent = 5f;
    public float distractionMax = 5f;

    public static float thesis = 0f;
    public float ThesisMax = 10f;

    bool isDie=false;
    bool isFinish = false;

    public Image TimeBar;//타임바
    public Image ThesisBar;
   

    public Canvas GameOn;
    public Canvas GameFail;
    public Canvas GameSuccess;
    // Start is called before the first frame update
    void Start()
    {
     
        GameFail.enabled = false;
        ThesisBar.fillAmount = 0;
    }

    

    // Update is called once per frame
    private void Update()
    {
      


        if (!isDie)
        {
          

            TimeBar.fillAmount = distractionCurrent / distractionMax;


            if (distractionCurrent == 0)
            {
                isDie = true;
                GameOn.enabled = false;
                GameFail.enabled = true;
                Time.timeScale = 0;
                Sound.Instance.StopSound("bgm");
            }
        }

        if (!isFinish)
        {

            ThesisBar.fillAmount =  thesis / ThesisMax;

            if (ThesisBar.fillAmount == 1)
            {
                isFinish = true;
                GameOn.enabled = false;
                GameSuccess.enabled = true;
                Time.timeScale = 0;
                Sound.Instance.StopSound("bgm");

            }
        }

        

    }
}
