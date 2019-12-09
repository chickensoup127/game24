using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Playerstatus : MonoBehaviour
{

    public GameObject _player = null;
    public Text _playerStatusText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (_player != null)
        {
            _playerStatusText.text = " X " + _player.GetComponent<Entity>().bv._hp;
        }
    }
}
