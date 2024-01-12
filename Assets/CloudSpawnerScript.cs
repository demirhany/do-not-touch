using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 2.0f;
    private float timer = 0;
    public const float heigthOffSet = 5;

    void Start()
    {
        spawnCloud();
    }

    void Update()
    {
        if(timer < spawnRate)
        { timer += Time.deltaTime; }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }

    public void spawnCloud()
    {
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(transform.position.y - heigthOffSet, transform.position.y + heigthOffSet), transform.position.z),transform.rotation);
    }
}
