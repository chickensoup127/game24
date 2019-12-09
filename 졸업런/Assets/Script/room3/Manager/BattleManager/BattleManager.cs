using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : Manager
{
    public GameObject UI_GameOver;
    public GameObject UI_Ending;
    public GameObject UI_PS;
    public SoundController sound_background ;
    public GameObject sound_dead;
    List<Collision> _collisionLst = new List<Collision>();
    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in _collisionLst)
        {
            CalcBv(item);
        }
        _collisionLst.Clear();

    }

    private bool IsValidCollison(Collision col)
    {
        bool ret = false;

        /*
		 처리해야하는 충돌
		  - sender: 미사일 , receiver: 적
		  - sender: 적 , receiver: 플레이어
		  - sender: 적 미사일 , receiver: 플레이어
                   		
        */
        if ((col._sender.CompareTag("Player_Missile") && col._receiver.CompareTag("Enemy_Boss"))
            || (col._sender.CompareTag("Enemy_Boss") && col._receiver.CompareTag("Player"))
            || (col._sender.CompareTag("Enemy_Missile") && col._receiver.CompareTag("Player"))

            || (col._sender.CompareTag("Player_Missile") && col._receiver.CompareTag("Wall"))
            || (col._sender.CompareTag("Enemy_Missile") && col._receiver.CompareTag("Wall"))
            || (col._sender.CompareTag("Player") && col._receiver.CompareTag("Wall"))
            || (col._sender.CompareTag("Player") && col._receiver.CompareTag("Item_heart"))


            )
        {
            ret = true;
        }
         
        return ret;
    }

    public void AddCollision(Collision col)
    {

        if (IsValidCollison(col)) _collisionLst.Add(col);
    }

    private void CalcBv(Collision col)
    {
        GameObject sender = col._sender;
        GameObject receiver = col._receiver;
        BattleValue bvSender = sender.GetComponent<Entity>().bv;
        BattleValue bvReceiver = receiver.GetComponent<Entity>().bv;



        if (receiver.CompareTag("Item_heart"))
        {
            bvSender._hp += bvReceiver._atk;
            ObjectManager.instance.AddRemoveObj(receiver);

        }
        else
        {
            bvReceiver._hp -= bvSender._atk;
        }

        
            if (bvReceiver._hp <= 0)
        {
            if (receiver.CompareTag("Player") && UI_GameOver != null)
            {
                UI_PS.SetActive(false);
                Time.timeScale = 0;
                sound_background.offsound();
                UI_GameOver.SetActive(true);
                // 게임오버 ui를 보여준다.

            }
            else if(receiver.CompareTag("Enemy_Boss") && UI_Ending!= null)
            {
                Time.timeScale = 0;
                ObjectManager.instance.AddRemoveObj(receiver);
                sound_background.offsound();
                sound_dead.SetActive(true);
                UI_PS.SetActive(false);
                UI_Ending.SetActive(true);
            }
            else
            {
                ObjectManager.instance.AddRemoveObj(receiver);
            }

            
        }

        if (sender.CompareTag("Player_Missile") || sender.CompareTag("Enemy_Missile"))
        {
            
            ObjectManager.instance.AddRemoveObj(sender);
        }



    }
}
