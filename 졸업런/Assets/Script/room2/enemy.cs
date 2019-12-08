using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f, 5f );
    public Vector2 direction = new Vector2(1, 0);
    
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;


    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);

        if (transform.position.x < -30)
        {
            Destroy(gameObject);
        }

        if (transform.position.x >30)
        {
            Destroy(gameObject);
        }

    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // Apply movement to the rigidbody
        rigidbodyComponent.velocity = movement;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet")
        {
            Debug.Log("kill");
            Destroy(gameObject);
            Destroy(other);
        

        }

        if (other.tag=="Player")
        {
            Debug.Log("distracted");
            gameOn.distractionCurrent -= 1;
            Destroy(gameObject);

        }

    }
   
}
