using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -20;

    void Update()
    {
        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted.");
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 
    }
}
