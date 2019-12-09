using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
            SceneManager.LoadScene("room1");
    }

  /*  public void BtnClickstart()
    {
        if (Input.GetKey(KeyCode.Return))
            SceneManager.LoadScene("room1");
    }
    */
}
