﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStuff : MonoBehaviour
{
    public static float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.up * Time.deltaTime * speed;   
    }
}
