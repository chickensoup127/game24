﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float mapSpeed = 10f;

    private void Update()//맵스피드만큼 -x축으로 이동
    {
        transform.Translate(-mapSpeed * Time.deltaTime, 0, 0);
    }
}
