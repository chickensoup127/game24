using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : Entity
{
    float dt = 0;
    // Start is called before the first frame update
    void Start()
    {

        //GenMonster();
    }

    // Update is called once per frame
    void Update()
    {
       
           
    }

    void GenMonster()
    {
        GameObject prefab = Resources.Load("Enemy_Boss") as GameObject;
        GameObject Enemy = Instantiate(prefab);
        Enemy.transform.position = transform.position;
    }
}
