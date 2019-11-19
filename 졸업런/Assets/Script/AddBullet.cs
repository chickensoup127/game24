using System.Collections; using System.Collections.Generic; using UnityEngine;  public class AddBullet : MonoBehaviour {      float nowTime;     public GameObject bullect;     Rigidbody2D rigid;      public float jump = 10f;     public float jump2 = 12f;
    int jumpCount = 0;      public void Jump()
    {
        if(jumpCount == 0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jump);
            jumpCount += 1;
        }
        else if (jumpCount == 1)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jump2);
            jumpCount += 1;
        }
    }      // Use this for initialization  void Start () {         nowTime = Time.time;    }       // Update is called once per frame  void Update () {        if(Input.GetKeyDown(KeyCode.A) && Time.time - nowTime > 0.3f)         {                          GameObject b = Instantiate(bullect, transform.position, Quaternion.identity);             b.GetComponent<Bullet>().AddBullet(transform.position.x, transform.position.y, transform.position.z);             nowTime = Time.time;             Debug.Log("shoot");         }

        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            Jump();
            Debug.Log("jump");
        }    } 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            jumpCount = 0;
        }
    }


}


