using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 2.0f;
    public Vector2 _dir;
    public float Lifetime = Mathf.Infinity;
   

    // Use this for initialization


    void Start()
    {
        tag = "Bullet";
    }

    // Update is called once per frame
    void Update()

    {

        Vector2 moveV = _dir.normalized * Time.deltaTime * speed;
        transform.Translate(moveV);
        Destroy(gameObject, 10);
             }

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            Debug.Log("kill");
            Destroy(other);
            Destroy(gameObject);

        }
    }
}