using System.Collections; using System.Collections.Generic; using UnityEngine;   public class AddBullet : MonoBehaviour {

     
    public float _speed = 2.0f;     public float bulletVelocity=10f;
    private bool FireState;     public float FireDelay;      AudioSource shootingSound;        

    private Camera mainCamera;     Rigidbody2D rigid;     public GameObject player;      public float movespeed = 1f;
    public GameObject bullet1;
    
  

    // Use this for initialization

   


    void Start () {

        tag = "Player";
        FireState = true;
        rigid = gameObject.GetComponent<Rigidbody2D>();          
        
        

    }       // Update is called once per frame  void Update () {

        if (FireState)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                Vector2 direction = (Vector2)((worldMousePos - transform.position));
                direction.Normalize();
                StartCoroutine(ShootCtrl());

                // Creates the bullet locally
                GameObject bullet = (GameObject)Instantiate(
                                        bullet1,
                                        transform.position + (Vector3)(direction * 0.5f),
                                        Quaternion.identity);

                // Adds velocity to the bullet
                bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
                shootingSound.Play();
            }
        }

        

    }

  IEnumerator ShootCtrl()
    {
        FireState = false;
        yield return new WaitForSeconds(FireDelay);
        FireState = true;

    }

    void FixedUpdate()
    {
        Move();
        

    }


    void Move()
    {
        SpriteRenderer renderer = player.GetComponentInChildren<SpriteRenderer>();

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
            renderer.flipX = true;
        }

        if ((Input.GetAxisRaw("Horizontal") > 0))
        {
            moveVelocity = Vector3.right;
            Debug.Log("right");
            renderer.flipX = false;
        }

        

        transform.position += moveVelocity * movespeed * Time.deltaTime;

    }

    

   

    
        void OnTriggerEnter2D(Collider2D other)
        {
            
       
        if (other.CompareTag("Thesis"))
        {
            Debug.Log("thesis");
           
            Destroy(other.gameObject);
            gameOn.thesis += 1;


        }
    }


   

}



