using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float moveSpeed = 20;
    public float deadZone = -20;

    void Update()
    {
        if(transform.position.x < deadZone)
        { Destroy(gameObject); }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
