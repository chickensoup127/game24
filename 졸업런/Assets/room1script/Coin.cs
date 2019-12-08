using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //충돌
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0)
        {
            SoundManager.Instance.PlaySound("Coin");
            DataManager.Instance.score += 1;
            gameObject.SetActive(false);//화면에서 삭제
        }
    }
}
