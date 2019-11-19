using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Boss : Entity
{
    // Start is called before the first frame update
    void Start()
    {

        tag = "Enemy_Boss";
        
        InitBattleValue(5, 1);

    }
    private void OnEnable()
    {
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
