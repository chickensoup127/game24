using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // Start is called before the first frame update
    
    void Start()
    {
        tag = "Player";
        InitBattleValue(5, 1);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShootBullet(Vector3 targetpos)
    {

        Vector3 temp = new Vector3();
        temp = transform.position;
        temp.y += 1;
        GameObject bullet = ObjectManager.instance.GenerateObj("Player_Missile");
        bullet.GetComponent<Player_Bullet>().ApplyBattleValue(bv);
        bullet.transform.position = temp;
        bullet.GetComponent<Player_Bullet>()._dir = targetpos - bullet.transform.position;

    }
}
