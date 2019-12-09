using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void main()
    {
        SceneManager.LoadScene("main");
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("room2");

    }

    public void Sucees()
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
