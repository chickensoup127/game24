using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleValue : Data
{

    public BattleValue(float hp, float atk)
    {
        this.hp = hp;
        this._atk = atk;
    }
    private float hp;
    public float _hp
    {
        get { return hp; }
        set { hp = value; }
    }
    public float _atk { get; }
    
}
