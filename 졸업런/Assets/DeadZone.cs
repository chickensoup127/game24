using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadZone : MonoBehaviour
{
    public Canvas Score;

    //충돌
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!DataManager.Instance.PlayerDie)
        {
            if (collision.gameObject.tag.CompareTo("Player") == 0)
            {
                DataManager.Instance.PlayerDie = true;
                Time.timeScale = 0;
                SoundManager.Instance.StopSound("BG");//게임음악
                Score.enabled = false;
            }
        }
    }
}
