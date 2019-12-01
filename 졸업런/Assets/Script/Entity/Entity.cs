using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public GameObject _visualObj;
    private BattleValue _bv = null;
    public BattleValue bv { get { return _bv; } }
    // Start is called before the first frame update
    void Start()
    {
    }

    public void InitBattleValue(float hp, float atk)
    {
        _bv = new BattleValue(hp, atk);
    }

    public void Move(Vector2 moveVector)
    {
        transform.Translate(moveVector);
        //transform.FindChild("body").gameObject.GetComponent<Rigidbody2D>().AddForce(moveVector);
    }
}
