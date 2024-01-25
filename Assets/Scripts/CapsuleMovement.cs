using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    // Donne une impulsion vers la droite au démarrage
    
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.right * 400);
    }
}
