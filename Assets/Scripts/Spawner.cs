using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        InvokeRepeating("Spawn", 0, 1);
    }
    
    void Spawn()
    {
        GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity);
        obj.GetComponent<Rigidbody2D>().AddForce(Random.insideUnitCircle * 600);
    }
}
