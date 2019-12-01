using System.Collections; using System.Collections.Generic; using UnityEngine;  public class AddBullet : MonoBehaviour {          public GameObject bullet;    
    public float _speed = 2.0f;     private bool shootstate;     

    private Camera mainCamera;     Rigidbody2D rigid;      public float movespeed = 1f;
 


    // Use this for initialization
    void Start () {

        tag = "Player";
        shootstate = true;
        rigid = gameObject.GetComponent<Rigidbody2D>();      
    }       // Update is called once per frame  void Update () {

        Shoot();

    }

     
    void FixedUpdate()
    {
        Move();
        Shoot();
    }


    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Vertical")>0)
        {
            moveVelocity = Vector3.up;
            Debug.Log("up");
        }

        if (Input.GetAxisRaw("Vertical")<0)
        {
            moveVelocity = Vector3.down;
            Debug.Log("down");
        }

        if (Input.GetAxisRaw("Horizontal")<0)
        {
            moveVelocity = Vector3.left;
            Debug.Log("left");
        }

        if ((Input.GetAxisRaw("Horizontal") > 0))
        {
            moveVelocity = Vector3.right;
            Debug.Log("right");
        }

        

        transform.position += moveVelocity * movespeed * Time.deltaTime;

    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0)&&shootstate) 
        {
            shootstate = false;
            Vector3 Mouseposition = Input.mousePosition;
            Mouseposition = mainCamera.ScreenToWorldPoint(Mouseposition);
           
            //GameObject b= Instantiate(bullet, Mouseposition, Quaternion.identity);
            GameObject b = ObjectManager.instance.GenerateObj("Bullet");

            bullet.transform.position = transform.position;
           b.GetComponent<Bullet>()._dir = Mouseposition - bullet.transform.position;
            StartCoroutine(ShootCtrl());
            Debug.Log("Shoot");
        }

        
    }

    IEnumerator ShootCtrl()
    {
        
        
       
        yield return new WaitForSeconds(0.5f);
       
        shootstate = true;


    }

    
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "enemy")
            {
                Debug.Log("distracted");
                //집중력감소 추가하기

            }
        }
    
}



