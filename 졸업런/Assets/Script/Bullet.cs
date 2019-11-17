using System.Collections; using System.Collections.Generic; using UnityEngine;  public class Bullet : MonoBehaviour
{

    // Use this for initialization

    float xpos;     float ypos;     float zpos;     float speed = 0.1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {         transform.position = new Vector3(xpos, ypos, zpos);         ypos += speed;          if(ypos > 10)
        {
            Destroy(gameObject);
        }     }

    public void AddBullet(float x, float y, float z)
    {
        xpos = x;
        ypos = y;
        zpos = z;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            Debug.Log("kill");
            Destroy(other);

        }
    }
}