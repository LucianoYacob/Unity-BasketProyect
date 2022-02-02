﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFront : MonoBehaviour
{
    public float speedMove = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speedMove * Time.deltaTime, Space.Self);
    }
}
