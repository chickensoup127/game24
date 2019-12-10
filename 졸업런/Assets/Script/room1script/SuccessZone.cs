using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SuccessZone : MonoBehaviour
{

    public Canvas Score;
 

    void Start()
    {
        
}
    //충돌
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0)
        {
            DataManager.Instance.Success = true;
            Score.enabled = false;
            Time.timeScale = 0;
            


        }
    }
}
