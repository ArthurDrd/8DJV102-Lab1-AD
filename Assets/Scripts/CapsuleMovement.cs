using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{ 
    public float force = 400;
    public float mass = 1;
    
    void Start()
    {
        float acceleration = force / mass;
        
        GetComponent<Rigidbody2D>().AddForce(Vector3.right * acceleration);
    }
}
