using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticVal : MonoBehaviour
{
    public static int gameScore = 0;

    private void Awake()
    {
        gameScore = 0;
    }
}
