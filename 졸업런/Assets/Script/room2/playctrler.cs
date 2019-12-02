using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playctrler : Entity
{
    public GameObject _player;
    private Camera mainCamera; // 메인 카메라
    private bool check = true;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void ShootBullet(Vector3 targetpos)
    {

        GameObject bullet = ObjectManager.instance.GenerateObj("Bullet");

        bullet.transform.position = transform.position;
        bullet.GetComponent<Bullet>()._dir = targetpos - bullet.transform.position;

    }


}
