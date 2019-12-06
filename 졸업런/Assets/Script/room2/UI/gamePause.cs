using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamePause : MonoBehaviour {

    // Use this for initialization

    public Canvas paused;
  

    void Start () {
        paused.enabled = false;
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {

            Time.timeScale = 0;
            paused.enabled = true;



        }

    
      

    }

    public void Resume()
    {
        Time.timeScale = 1;
        paused.enabled = false;
    }

 

}
