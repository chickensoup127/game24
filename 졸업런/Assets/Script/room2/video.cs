using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class video : MonoBehaviour
{
    public VideoPlayer fail;
    public VideoPlayer success;


    public Canvas GameFail;
    public Canvas GameSuccess;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (GameFail.enabled == true)
        {
            fail.Play();

          
            
        }

        else
        {
            fail.Stop();
        }

       
        if (GameSuccess.enabled == true)
            
        {
            success.Play();

        }

        else
        {
            success.Stop();
        }


    }

   


}