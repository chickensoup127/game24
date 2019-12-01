using System.Collections; using System.Collections.Generic; using UnityEngine;  public class AddBullet : MonoBehaviour {          public GameObject bullet;     float vel = 20f;     Rigidbody2D rigid;      public float movespeed = 1f;     Vector3 movement;              // Use this for initialization  void Start () {              rigid = gameObject.GetComponent<Rigidbody2D>();    }       // Update is called once per frame  void Update () {
        

        Shoot();    }      void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            GameObject b = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
            Vector3 screenPos = Input.mousePosition;

            screenPos.z = 5.46f; //screenPos.z는 카메라와의 거리이다.

            Vector3 worldPos = GetComponent<Camera>().ScreenToWorldPoint(screenPos);

            Vector3 dir = (worldPos - transform.position).normalized;

            bullet.GetComponent<Rigidbody2D>().velocity = dir * vel;;
            Debug.Log("shoot");
        }

    } 
    void FixedUpdate()
    {
        Move();
    }


    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Vertical")>0)
        {
            moveVelocity = Vector3.up;
        }

        if (Input.GetAxisRaw("Vertical")<0)
        {
            moveVelocity = Vector3.down;
        }

        if (Input.GetAxisRaw("Horizontal")>0)
        {
            moveVelocity = Vector3.left;
        }

        if ((Input.GetAxisRaw("Horizontal") < 0))
        {
            moveVelocity = Vector3.right;
        }

        transform.position += moveVelocity * movespeed * Time.deltaTime;

    }
}


