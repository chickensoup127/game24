using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnEnable()
    {
        GenObj();
    }
    void GenObj()
    {
         GameObject Obj = Instantiate(_obj);
        Obj.transform.position = transform.position;
    }
}
