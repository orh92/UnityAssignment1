﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToRotate : MonoBehaviour
{

    private float speed = 0.4f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed);//y
        transform.Rotate(Vector3.forward * speed);//z
        transform.Rotate(Vector3.right * speed);//x
    }
}
