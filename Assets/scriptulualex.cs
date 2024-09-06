using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class scriptulualex : MonoBehaviour
{
     public Rigidbody2D MyRigidbody;
     public float flapStrength;
     public LogicScript logic;
     public bool birdIsAlive = true;
     void Start()
     {
          logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
     }

     void Update()
     {
     

          if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
          {
               MyRigidbody.velocity = Vector2.up * flapStrength;
          }

          if ((Mouse.current.leftButton.wasPressedThisFrame) && birdIsAlive)
          {
               MyRigidbody.velocity = Vector2.up * flapStrength;
          }

          if ((Input.touchCount > 0) && birdIsAlive)
          {
               MyRigidbody.velocity = Vector2.up * flapStrength;
          }
          

     }
     private void OnCollisionEnter2D(Collision2D collision)
     {
          logic.gameOver();
          birdIsAlive = false;
     }

}
