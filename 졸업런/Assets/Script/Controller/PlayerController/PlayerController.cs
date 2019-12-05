using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public GameObject _player;
    public float _speed=2.0f;
    public GameObject UI_Pause;

    private Camera mainCamera; // 메인 카메라
    private bool check = true;
    public Animator animator;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        rigid = _player.GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 moveV = Vector3.zero;
        SpriteRenderer renderer = _player.GetComponentInChildren<SpriteRenderer>();

        if (Input.GetKey(KeyCode.S))
        {
            //Vector3 temp= Vector3.down;
            //moveV += temp;
    
            moveV.y -= 1;
            animator.SetInteger("Is_Move",3);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Vector3 temp = Vector3.left;
            //moveV += temp;
            moveV.x -= 1;
            renderer.flipX = true;
            animator.SetInteger("Is_Move", 1);

        }
        if (Input.GetKey(KeyCode.D))
        {
            //Vector3 temp = Vector3.right;
            //moveV += temp ;
            moveV.x += 1;

            renderer.flipX = false;
            animator.SetInteger("Is_Move", 1);

        }
        if (Input.GetKey(KeyCode.W))
        {
            //Vector3 temp = Vector3.up;
            //moveV += temp;
            moveV.y += 1;
            animator.SetInteger("Is_Move", 2);
        }
        

        if (Input.GetMouseButton(0)&&check&&Time.timeScale==1)
        {
            check = false;
            Vector3 Mouseposition = Input.mousePosition;
            Mouseposition = mainCamera.ScreenToWorldPoint(Mouseposition);
            _player.GetComponent<Player>().ShootBullet(Mouseposition);
            StartCoroutine(WaitForIt());
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            UI_Pause.SetActive(true);
        }

        //rigid.AddForce(moveV, ForceMode2D.Impulse);
        //transform.position += moveV*1.0f*Time.deltaTime;
        moveV = moveV.normalized * _speed * Time.deltaTime;
        _player.GetComponent<Entity>().Move(moveV);

    }
    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(0.5f);
        check = true;
    }
}
