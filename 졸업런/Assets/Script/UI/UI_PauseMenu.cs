using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI_PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UI_Pause;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            UI_Pause.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Resume()
    {
        UI_Pause.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene("room1");
        
    }
    public void Quitgame()
    {
        Application.Quit();
    }
}
