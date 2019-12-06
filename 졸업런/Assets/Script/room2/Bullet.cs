using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : root_Bullet
{

    

    

    // Use this for initialization


    void Start()
    {
    }

    // Update is called once per frame
    void Update()

    {

        Vector2 moveV = _dir.normalized * Time.deltaTime * _speed;
        Move(moveV);     }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="enemy")
            
        {
            Destroy(gameObject);
        }
    }


}