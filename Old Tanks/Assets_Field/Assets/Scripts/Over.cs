﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour
{
    public GameObject GameOverText;
    public static GameObject GameOverStatic;

    void Start()
    {
        Over.GameOverStatic = GameOverText;
        Over.GameOverStatic.gameObject.SetActive(false);
    }

    public static void show()
    {
        Over.GameOverStatic.gameObject.SetActive(true);
    }
}
