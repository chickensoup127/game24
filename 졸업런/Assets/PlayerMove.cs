using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jump = 10f; //첫번째 점프값
    public float jump2 = 12f; //두번째 점프값

    int jumpCount = 0;

    //버튼함수
    public void Jump_Btn()
    {
        if (!DataManager.Instance.PlayerDie)
        {
            SoundManager.Instance.PlaySound("Jump");
            if (jumpCount == 0)//점프안함
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
                jumpCount += 1;
            }
            else if (jumpCount == 1)//점프한번
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
                jumpCount += 1;
            }
        }
    }

    //바닥 충돌 동작(착지)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            jumpCount = 0;
        }

        if(collision.gameObject.tag.CompareTo("Block")==0)
        {
            DataManager.Instance.playTimeCurrent -= 0.5f;
        }
    }

    //키보드입력
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump_Btn();
            Debug.Log("jump");
        }
    }

}
