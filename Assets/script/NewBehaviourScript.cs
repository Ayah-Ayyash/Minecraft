using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{

   public float minScale = 0.15f;
    public float maxScale = 0.10f;

    float scaleFactor = 6;
    float Speed = 0.05f;


    void Start()
    {
        scaleFactor = minScale;
       
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            
            scaleFactor -= Speed;
        }

        else if (Input.GetKey(KeyCode.D))
        {
          
            scaleFactor +=Speed ;
        }
        scaleFactor = Mathf.Clamp(scaleFactor, minScale, maxScale);

        transform.localScale = Vector3.one * scaleFactor;
    }
}