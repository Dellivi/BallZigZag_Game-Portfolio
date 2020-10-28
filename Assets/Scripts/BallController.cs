﻿using UnityEngine;
using System.Collections;


public class BallController : MonoBehaviour
{

    [SerializeField] private float speed = 1f;

    [SerializeField] private GameManager gm;

    private bool changeDir = false;

    public bool ChangeDir { get => changeDir; set => changeDir = value; }

    // Update is called once per frame
    void Update()
    {

        if (ChangeDir && gm.IsGameStart)
        {
            transform.Translate(new Vector3(0, 0, -1f) * Time.deltaTime * speed);
        }
        else if (!ChangeDir && gm.IsGameStart)
        {
            transform.Translate(new Vector3(1f, 0, 0) * Time.deltaTime * speed);
        }
    }

}
