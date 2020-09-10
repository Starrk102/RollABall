using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
     public float rotatespeed = 10f;
    private float _startingPosition;

 
     private void Update () 
     {
     if (Input.touchCount > 0)
     {
         Touch touch = Input.GetTouch(0);
         switch (touch.phase)
         {
             case TouchPhase.Began:
                 _startingPosition = touch.position.x;
                 break;
             case TouchPhase.Moved:
                 if (_startingPosition > touch.position.x)
                 {
                     transform.Rotate(Vector3.back, -rotatespeed * Time.deltaTime);
                 }
                 else if (_startingPosition < touch.position.x)
                 {
                     transform.Rotate(Vector3.back, rotatespeed * Time.deltaTime);
                 }
                 break;
             case TouchPhase.Ended:
                 Debug.Log("Touch Phase Ended.");
                 break;
             }
         }
     }
    }
 
 
