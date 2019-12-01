using System.Collections; using System.Collections.Generic; using UnityEngine;  public class Bullet : MonoBehaviour
{

    Vector3 pos;
    float speed = 5f;

    // Use this for initialization

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        pos = transform.position;         pos.x += speed*Time.deltaTime;
        transform.position = pos;
            Destroy(gameObject, 10);
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