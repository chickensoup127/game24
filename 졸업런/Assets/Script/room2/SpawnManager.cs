using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

{
    public bool enableSpawn = false;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;


    //float time;
    void SpawnEnemy1()
    {
    
        if (enableSpawn)
        {
            float randomX = Random.Range(-32f, 32f);
            float randomY = Random.Range(5f, -0.5f);
            GameObject enemy1 = (GameObject)Instantiate(Enemy1, new Vector3(randomX, randomY, 0f), Quaternion.identity); //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
            
        }
    }

    void SpawnEnemy2()
    {
       
        if (enableSpawn)
        {

            float randomX = Random.Range(-32f, 32f);
            float randomY = Random.Range(5f, -0.5f);
            GameObject enemy2 = (GameObject)Instantiate(Enemy2, new Vector3(randomX, randomY, 0f), Quaternion.identity);
         
        }
    }

    void SpawnEnemy3()
    {
        if (enableSpawn)
        {
            float randomX = Random.Range(-32f, 32f);
            float randomY = Random.Range(5f, -0.5f);
            GameObject enemy3 = (GameObject)Instantiate(Enemy3, new Vector3(randomX, randomY, 0f), Quaternion.identity);
        }
    }

    /*void SpawnEnemy3()
    {
        float randomX = Random.Range(-32f, 32f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomY = Random.Range(5f, -0.5f);
        if (enableSpawn)
        {
            GameObject enemy1 = (GameObject)Instantiate(Enemy1, new Vector3(randomX, randomY, 0f), Quaternion.identity); //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
            GameObject enemy2 = (GameObject)Instantiate(Enemy2, new Vector3(randomX, randomY, 0f), Quaternion.identity);
            GameObject enemy3 = (GameObject)Instantiate(Enemy3, new Vector3(randomX, randomY, 0f), Quaternion.identity);
        }
    }*/
    void Start()
    {
       
        InvokeRepeating("SpawnEnemy1", 5, 2); //5초후 부터, SpawnEnemy함수를 2초마다 반복해서 실행 시킵니다.
        InvokeRepeating("SpawnEnemy2", 7, 3);
        InvokeRepeating("SpawnEnemy3", 8, 4);

    }
    void Update()
    {

    }
}