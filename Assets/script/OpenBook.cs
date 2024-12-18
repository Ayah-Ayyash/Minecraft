using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    float bookRotationSensitivity = 200.0f; 
    float zAngle = 0.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            zAngle += bookRotationSensitivity * Time.deltaTime;
            zAngle = Mathf.Clamp(zAngle, 0, 180); 
            transform.rotation = Quaternion.Euler(0, 0, zAngle);
        }
        else if (Input.GetKey(KeyCode.A)) 
        {
            zAngle -= bookRotationSensitivity * Time.deltaTime;
            zAngle = Mathf.Clamp(zAngle, 0, 180); 
            transform.rotation = Quaternion.Euler(0, 0, zAngle);
        }
    }
}

