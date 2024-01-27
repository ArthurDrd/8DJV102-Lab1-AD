using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{ 
    public float acceleration= 400;
    public float mass = 1;
    
    void Start()
    {
        float force = acceleration / mass;
        
        GetComponent<Rigidbody2D>().AddForce(Vector3.right * force);
    }
}
