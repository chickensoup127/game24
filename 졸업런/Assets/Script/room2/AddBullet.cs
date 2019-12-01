using System.Collections; using System.Collections.Generic; using UnityEngine;  public class AddBullet : MonoBehaviour {      float nowTime;     public GameObject bullect;     Rigidbody2D rigid;      public float movespeed = 1f;     Vector3 movement;              // Use this for initialization  void Start () {         nowTime = Time.time;         rigid = gameObject.GetComponent<Rigidbody2D>();    }       // Update is called once per frame  void Update () {        if(Input.GetKeyDown(KeyCode.A) && Time.time - nowTime > 0.3f)         {                          GameObject b = Instantiate(bullect, transform.position, Quaternion.identity);             b.GetComponent<Bullet>().AddBullet(transform.position.x, transform.position.y, transform.position.z);             nowTime = Time.time;             Debug.Log("shoot");         }

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


