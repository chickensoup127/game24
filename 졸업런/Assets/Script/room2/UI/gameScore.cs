using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameScore : MonoBehaviour
{

    public Text thesis_num;
    public Text distraction_num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        thesis_num.text = gameOn.thesis.ToString();
        distraction_num.text = gameOn.distractionCurrent.ToString()+"/5";
    }
}
