using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{


    public void main()
    {
        SceneManager.LoadScene("main");
        Sound.Instance.StopSound("bgm");
        gameOn.thesis = 0f;
        gameOn.distractionCurrent = 5f;

        Time.timeScale = 1;


    }

    public void Restart()
    {
        //Sound.Instance.PlaySound("bgm");
        gameOn.thesis = 0f;
        gameOn.distractionCurrent = 5f;
        Time.timeScale = 1;

        SceneManager.LoadScene("room2");

    }

    public void Sucess()
    {
        SceneManager.LoadScene("room3");
      
    }



    public void Quitgame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


}
