﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    static DataManager instance;
    public bool PlayerDie = false;
    public static DataManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
    //스코어 저장하는곳
    public int score = 0;
}

