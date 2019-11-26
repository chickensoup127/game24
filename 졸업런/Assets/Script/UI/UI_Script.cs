using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Script : MonoBehaviour
{
    public GameObject spawner;
    public GameObject _owner;
    // Start is called before the first frame update
    void Start()
    {


        spawner.SetActive(true);
        _owner.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
