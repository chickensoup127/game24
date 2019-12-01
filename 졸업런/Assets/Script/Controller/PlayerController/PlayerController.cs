using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public GameObject _player;
    public float _speed=2.0f;
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
        Vector2 moveV = Vector2.zero;
        if (Input.GetKey(KeyCode.S))
        {
            moveV.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveV.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveV.x += 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveV.y += 1;
        }

        if (Input.GetMouseButton(0)&&check)
        {
            check = false;
            Vector3 Mouseposition = Input.mousePosition;
            Mouseposition = mainCamera.ScreenToWorldPoint(Mouseposition);
            _player.GetComponent<Player>().ShootBullet(Mouseposition);
            StartCoroutine(WaitForIt());

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
