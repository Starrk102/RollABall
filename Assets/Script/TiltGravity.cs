using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltGravity : MonoBehaviour
{
    public float gravityScale = 1.0f;
    private static Vector3 globalGravity;
    private Rigidbody rb;
    private Quaternion rotation;
    public Vector2 deltaPosition;
    public Vector2 rotationAdjust = new Vector2(1, 1);
    public Vector3 gravity = new Vector3();
    public float maxRotation = 20f;
    public float minRotation = -20f;
    


    private void OnEnable ()
    {
        globalGravity = Physics.gravity * gravityScale;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
 
        rb.AddForce(globalGravity, ForceMode.Acceleration);
    }
 
    private void Update()
    {
        //rotation = Quaternion.Euler(-Mathf.Clamp(rotationAdjust.y, minRotation, maxRotation), 0, Mathf.Clamp(rotationAdjust.x, minRotation, maxRotation));
    }
    
    private void FixedUpdate ()
    {
        gravity = rotation * globalGravity;
        rb.AddForce(gravity, ForceMode.Acceleration);
    }
}