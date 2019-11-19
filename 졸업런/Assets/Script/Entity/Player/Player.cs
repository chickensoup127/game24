using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // Start is called before the first frame update
    void Start()
    {
        tag = "Player";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShootBullet()
    {
        GameObject prefab = Resources.Load("playerBullet") as GameObject;
        GameObject bullet = Instantiate(prefab);

        //GameObject bullet = ObjectManager.instance.GenerateObj("Missile");
        //bullet.GetComponent<Bullet>().ApplyBattleValue(bv);
        //bullet.transform.position = transform.position;
    }
}
