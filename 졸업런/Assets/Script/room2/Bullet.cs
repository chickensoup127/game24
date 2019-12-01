using System.Collections; using System.Collections.Generic; using UnityEngine;  public class Bullet : MonoBehaviour
{

    // Use this for initialization

    float xpos;     float ypos;         float speed = 0.1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {         transform.position = new Vector2(xpos, ypos);         xpos += speed;          if(xpos > 10)
        {
            Destroy(gameObject);
        }     }

    public void AddBullet(float x, float y, float z)
    {
        xpos = x;
        ypos = y;
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            Debug.Log("kill");
            Destroy(other);
            Destroy(gameObject);

        }
    }
}