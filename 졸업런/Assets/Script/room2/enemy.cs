using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(1, 0);

    float xpos;
    float ypos;

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

       /* transform.position = new Vector2(xpos, ypos);
        if (xpos > 32)
        {
            Destroy(gameObject);
        }*/
    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // Apply movement to the rigidbody
        rigidbodyComponent.velocity = movement;
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Debug.Log("kill");
            Destroy(gameObject);

        }
    }
}
