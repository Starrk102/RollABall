using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Touch touch;
    public float maxRotation = 20f;
    public float minRotation = -20f;
    private Vector2 touchPosition;
    private Quaternion rotationY;
    private float rotateSpeed = 0.1f;


    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch  = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0, -touch.deltaPosition.x * rotateSpeed, 0);
                transform.rotation = rotationY;
            }
        }
    }
}
