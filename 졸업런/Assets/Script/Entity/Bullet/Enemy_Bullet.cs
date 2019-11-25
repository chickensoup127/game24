using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : root_Bullet
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ApplyBattleValue(BattleValue bv)
    {
        tag = "Enemy_Missile";
        InitBattleValue(bv._hp, 1);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveV = _dir.normalized * Time.deltaTime * _speed;
        Move(moveV);
    }
}
