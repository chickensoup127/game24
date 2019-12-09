using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    // Start is called before the first frame update
    void Start()
    {
        tag = "Enemy";
        InitBattleValue(10, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
