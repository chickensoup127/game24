using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // Start is called before the first frame update
    void Start()
    {
        tag = "Player";
        InitBattleValue(int.MaxValue, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShootBullet()
    {
     
        GameObject bullet = ObjectManager.instance.GenerateObj("Player_Missile");
        bullet.GetComponent<Player_Bullet>().ApplyBattleValue(bv);
        bullet.transform.position = transform.position;
    }
}
