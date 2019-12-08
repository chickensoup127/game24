using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessZone : MonoBehaviour
{
    //충돌
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0)
        {
            DataManager.Instance.Success = true;
        }
    }
}
