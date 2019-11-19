using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet :Entity
{
    public GameObject _owner;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void ApplyBattleValue(BattleValue bv)
    {
        tag = "Player_Missile";
        InitBattleValue(bv._hp, 1);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveV = Vector3.zero;
        moveV.y += Time.deltaTime * 1.5f;
        Move(moveV);

       
    }
}
