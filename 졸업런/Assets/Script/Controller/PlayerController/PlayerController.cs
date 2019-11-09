using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public GameObject _player;
    public float _speed=2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveV = Vector2.zero;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveV.y -= 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveV.x -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveV.x += 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveV.y += 1;
        }
        moveV = moveV.normalized * _speed * Time.deltaTime;
        _player.GetComponent<Entity>().Move(moveV);

    }
}
