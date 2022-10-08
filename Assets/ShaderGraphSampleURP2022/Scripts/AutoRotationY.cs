using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotationY : MonoBehaviour
{

    public bool Enable = true;

    public float RotateSpeed = 1.0f;

    float _defaultRotationY = 0.0f;

    void Awake()
    {
        _defaultRotationY = transform.localRotation.y;
    }

    void Update()
    {
        if (Enable)
        {
            transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0.0f, _defaultRotationY, 0.0f);
        }
    }
}
