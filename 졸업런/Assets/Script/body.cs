using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{

    public GameObject _owner = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        //_owner.transform.position = transform.position;
        //사용하면 플레이어가 벽 밖으로 튀어나가지 않음
        //대신에 모든 이동 함수를 rigidbody 이동으로 바꿔야함
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collision col = new Collision();
        col._sender = _owner;
        col._receiver = collision.gameObject.GetComponent<body>()._owner;
        CollisionDispatcher.instance.DispatchCollision(col);
    }
}
