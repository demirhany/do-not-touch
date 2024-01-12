using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    private AudioSource jumpAuidoSource;
    public Collider2D cantainerColliderTop;
    public Collider2D cantainerColliderBottom;
    private Quaternion targetRotation;
    public Vector3 rotationVector;
    public bool birdIsAlive = true;
    public float flapStrength;

    void Start()
    {
        targetRotation = transform.rotation;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        jumpAuidoSource = GetComponent<AudioSource>();
        jumpAuidoSource.mute = true;
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.UpArrow) == true && birdIsAlive == true)
        {
            jumpAuidoSource.mute = false;
            jumpAuidoSource.Play();
            myRigidbody.velocity = Vector2.up * flapStrength;
            transform.Rotate(0, 0, -15);
            rotationVector = myRigidbody.transform.rotation.eulerAngles;
            targetRotation *= Quaternion.Euler(0, 0, 0);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5f);

        if (GetComponent<Collider2D>().IsTouching(cantainerColliderTop)|| GetComponent<Collider2D>().IsTouching(cantainerColliderBottom))
        {
            birdIsAlive = false;
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.gameOver();
    }
}
