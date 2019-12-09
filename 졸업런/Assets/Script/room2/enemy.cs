using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f, 5f );
    public Vector2 direction = new Vector2(1, 0);
    
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;
    public GameObject ParticleDestroy;
    public GameObject ParticleDistracted;
    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        
        tr=GetComponent<Transform>();

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
            Sound.Instance.PlaySound("destroy");
            Instantiate(ParticleDestroy, tr.position, Quaternion.identity);


        }

       if (other.tag=="Player")
        {
            Debug.Log("distracted");
            gameOn.distractionCurrent -= 1;
            Destroy(gameObject);
            direction = new Vector2(0, 0);
            Sound.Instance.PlaySound("distracted");
            Instantiate(ParticleDistracted, tr.position, Quaternion.identity);
           

        }

    }

    


}
