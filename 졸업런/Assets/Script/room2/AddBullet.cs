using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.UI;  public class AddBullet : MonoBehaviour {

     
    public float _speed = 2.0f;     public float bulletVelocity=10f;       private bool shootstate;     

    private Camera mainCamera;     Rigidbody2D rigid;     public GameObject player;      public float movespeed = 1f;
    public GameObject bullet1;
  
    public Text thesis;
    int score = 0;
    public Text Distraction;
    int concen = 10;

    public Canvas start;
    public Canvas fail;
    public Canvas success;
    // Use this for initialization

    Vector3 shootDirection;


    void Start () {

        tag = "Player";
        shootstate = true;
        rigid = gameObject.GetComponent<Rigidbody2D>();          thesis.text = "" + score;
        Distraction.text = ":" + concen;

    }       // Update is called once per frame  void Update () {

        SpriteRenderer renderer = player.GetComponentInChildren<SpriteRenderer>();
        tag = "Bullet";
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = (Vector2)((worldMousePos - transform.position));
            direction.Normalize();

            // Creates the bullet locally
            GameObject bullet = (GameObject)Instantiate(
                                    bullet1,
                                    transform.position + (Vector3)(direction * 0.5f),
                                    Quaternion.identity);

            // Adds velocity to the bullet
            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
        }

        UI();

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
            if (other.CompareTag("enemy"))
            {
                Debug.Log("distracted");
                

            }
       
        if (other.CompareTag("Thesis"))
        {
            Debug.Log("thesis");
            Destroy(other.gameObject);


        }
    }


    void UI()
    {
        
    }

}



