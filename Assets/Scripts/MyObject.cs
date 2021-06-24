using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour
{
    public float forwardSpeed = 2f;
    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * forwardSpeed);
    }
}
