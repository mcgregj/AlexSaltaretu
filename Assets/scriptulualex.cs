using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptulualex : MonoBehaviour
{
        public Rigidbody2D MyRigidbody;
        public float flapStrength;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
             MyRigidbody.velocity = Vector2.up * flapStrength;
        }
      
    }
}
