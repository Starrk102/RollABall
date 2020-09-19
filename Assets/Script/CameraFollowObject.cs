 using UnityEngine;
 using System.Collections;
 
 public class CameraFollowObject : MonoBehaviour
 {
    public Transform TargetObject;
    public float followDistance = 5f;
    public float followHeight = 2f;
    public bool smoothedFollow = false;         
    public float smoothSpeed = 5f;
    public bool useFixedLookDirection = false;      
    public Vector3 fixedLookDirection = Vector3.one;
     
     void Update ()
     {
        Vector3 lookToward = TargetObject.position - transform.position;
        if (useFixedLookDirection)
        {
            lookToward = fixedLookDirection;
        }

        Vector3 newPos;
        newPos = TargetObject.position - lookToward.normalized * followDistance;
        newPos.y = TargetObject.position.y + followHeight;

        if (!smoothedFollow)
        {
            transform.position = newPos;
        }
        else
        {
            transform.position += (newPos - transform.position) * Time.deltaTime * smoothSpeed;
        }


        lookToward = TargetObject.position - transform.position;


        transform.forward = lookToward.normalized;
    }
 }