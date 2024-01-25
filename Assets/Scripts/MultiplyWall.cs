using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyWall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().velocity *= 3;
        collision.gameObject.transform.Rotate(0, 0, 90);
    }
}
