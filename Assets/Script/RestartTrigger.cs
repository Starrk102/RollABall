using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartTrigger : MonoBehaviour
{   
    [SerializeField]
    private Transform Sphere;
    private void OnTriggerEnter(Collider other) 
    {
        Sphere.transform.position = new Vector3(0, 2, 0);
    }
}
