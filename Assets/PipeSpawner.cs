using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public const float heigthOffSet = 3;

    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if(timer < spawnRate)
        { timer = timer + Time.deltaTime; }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(transform.position.y - heigthOffSet, transform.position.y + heigthOffSet), 0), transform.rotation); //it creates the pipe object in every frame 
    } 
}
