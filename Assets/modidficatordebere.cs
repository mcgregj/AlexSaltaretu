using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modidficatordebere : MonoBehaviour
{
    public float moveSpeed = 5;
    public float Deadzone = -23;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < Deadzone)
        {
            Debug.Log("bere consumata");
            Destroy(gameObject);

        }
    }
}
