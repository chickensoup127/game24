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
    
    // Update is called once per frame
    void Update()
    {
        Vector3 moveV = Vector3.zero;
        SpriteRenderer renderer = _player.GetComponentInChildren<SpriteRenderer>();
      
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            moveV = Vector3.up;

            animator.SetInteger("Is_Move", 2);
            // Debug.Log("up");
        }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            moveV = Vector3.down;

            //animator.SetInteger("Is_Move", 0);
            //Debug.Log("down");
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveV= Vector3.left;
            //Debug.Log("left");

            animator.SetInteger("Is_Move", 1);

            renderer.flipX = true;
        }

        if ((Input.GetAxisRaw("Horizontal") > 0))
        {
            moveV = Vector3.right;
            animator.SetInteger("Is_Move", 1);
            
            //Debug.Log("right");

            renderer.flipX = false;
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

        moveV = moveV.normalized * _speed * Time.deltaTime;
        _player.GetComponent<Entity>().Move(moveV);

    }
    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(0.5f);
        check = true;
    }
}
