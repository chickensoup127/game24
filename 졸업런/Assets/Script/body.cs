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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Collision col = new Collision();

        col._sender = _owner;
        col._receiver = collision.gameObject.GetComponent<body>()._owner;

       

            CollisionDispatcher.instance.DispatchCollision(col);
    }
}
