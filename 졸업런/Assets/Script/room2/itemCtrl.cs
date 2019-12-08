using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCtrl : MonoBehaviour
{
    public bool Spawn = false;
    public GameObject book; //Prefab을 받을 public 변수 입니다.
    //float time;
    void SpawnBook()
    {
        float randomX = Random.Range(-32f, 0f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomY = Random.Range(5f, -0.5f);
        if (Spawn)
        {
            GameObject Book = (GameObject)Instantiate(book, new Vector3(randomX, randomY, 0f), Quaternion.identity); //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
        }
    }
    void Start()
    {

        InvokeRepeating("SpawnBook", 1, 2); //5초후 부터, SpawnEnemy함수를 2초마다 반복해서 실행 시킵니다.

    }
    void Update()
    {
        
    }
}