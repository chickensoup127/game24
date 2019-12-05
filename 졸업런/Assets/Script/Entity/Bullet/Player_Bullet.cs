using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet :root_Bullet
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = Quaternion.LookRotation(_dir);
    }

    public void ApplyBattleValue(BattleValue bv)
    {
        tag = "Player_Missile";
        InitBattleValue(bv._hp, 1);
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 moveV = _dir.normalized * Time.deltaTime * _speed;
        Move(moveV);
    }
}
