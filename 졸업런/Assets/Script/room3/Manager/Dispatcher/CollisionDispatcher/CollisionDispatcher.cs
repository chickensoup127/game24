using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDispatcher : Dispatcher
{
    public static CollisionDispatcher instance = null;

    //List<Manager> _collisionReceiverLst = new List<Manager>();

    public BattleManager _bm;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DispatchCollision(Collision col)
    {
        _bm.AddCollision(col);
    }
}
