using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public Canvas gamestart;
    public Canvas GameOn;

    bool isPause = true;


    // Start is called before the first frame update
    void Start()
    {
        
            gamestart.enabled = true;
            Time.timeScale = 0;
        GameOn.enabled = false;
        
        
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Time.timeScale = 1;
            gamestart.enabled = false;
            GameOn.enabled = true;
        }

    }

   
}
