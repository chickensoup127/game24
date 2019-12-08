using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Boss : Entity
{
    private bool check = true;
    public int _hp=5;
    // Start is called before the first frame update
    void Start()
    {
        tag = "Enemy_Boss";
        InitBattleValue(_hp, 1);
        StartCoroutine("Shoot" + Random.Range(1, 3));
    }

    private void OnEnable()
    {
    }
    // Update is called once per frame
    void Update()
    {

        if (check)
        {
            check = false;
            StartCoroutine("Shoot" + Random.Range(1, 3));
            StartCoroutine(WaitForIt());
        }

    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(1.5f);
        check = true;
    }

    IEnumerator Shoot1()
    {
        yield return new WaitForSeconds(2.0f);
        for (int i = 0; i < 18; i++)
        {
            Vector3 v = new Vector3(Mathf.Cos(Mathf.Deg2Rad * 20 * i), Mathf.Sin(Mathf.Deg2Rad * 20 * i));

            ShootBullet(v);
        }

    }

    IEnumerator Shoot2()
    {
        yield return new WaitForSeconds(2.0f);
        for (int i = 9; i < 18; i++)
        {
            Vector3 v = new Vector3(Mathf.Cos(Mathf.Deg2Rad * 20 * i), Mathf.Sin(Mathf.Deg2Rad * 20 * i));

            ShootBullet(v);
        }

    }

    IEnumerator Shoot3()
    {
        yield return new WaitForSeconds(2.0f);
        for (int i = 14; i < 18; i++)
        {
            Vector3 v = new Vector3(Mathf.Cos(Mathf.Deg2Rad * 20 * i), Mathf.Sin(Mathf.Deg2Rad * 20 * i));

            ShootBullet(v);
        }

    }

    void ShootBullet(Vector3 dir)
    {
        GameObject bullet = ObjectManager.instance.GenerateObj("Enemy_Missile");//Instantiate(prefab);
        bullet.GetComponent<Enemy_Bullet>().ApplyBattleValue(bv);
        bullet.GetComponent<Enemy_Bullet>()._speed = 2.0f;
        bullet.GetComponent<Enemy_Bullet>()._dir = dir;
        bullet.transform.position = transform.position;
    }

   

}
