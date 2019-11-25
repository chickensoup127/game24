using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _enemy;
    public bool _spawn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_spawn == true)

        {
            GenMonster();
            _spawn = false;
        }
    }

    void GenMonster()
    {
        //GameObject prefab = Resources.Load(_enemy.tag) as GameObject;
        GameObject Enemy = Instantiate(_enemy);
        Enemy.transform.position = transform.position;
    }
}
