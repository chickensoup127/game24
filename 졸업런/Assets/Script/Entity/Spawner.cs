using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : Entity
{
    public GameObject _enemy;
    float dt = 0;
    // Start is called before the first frame update
    void Start()
    {

        GenMonster();
    }

    // Update is called once per frame
    void Update()
    {
       
           
    }

    void GenMonster()
    {
        GameObject prefab = Resources.Load(_enemy.tag) as GameObject;
        GameObject Enemy = Instantiate(prefab);
        Enemy.transform.position = transform.position;
    }
}
