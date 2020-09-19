using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion rotationY;
    private float rotateSpeedModifier = 0.5f;


    private void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            
            if(touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0f, 0f, -touch.deltaPosition.x * rotateSpeedModifier);
                transform.rotation = rotationY * transform.rotation;
            }
        } 
    }
}
 
 
