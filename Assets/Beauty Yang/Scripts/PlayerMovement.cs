using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed = 30f;
    public float jumpForce = 8f;
    public float groundCheckDist = 1.2f;

    public Vector3 direction;
    private Rigidbody rb;

    //camelCasing = Variables
    //PascalCasing = Scripts & Functions

    public int coins = 0;
    public int lives = 3;
    public float deathHeight = -3f;

    private Vector3 respawnPos;

    public float stunTimer = 2f;
    public bool isStunned = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        respawnPos = transform.position;
    }

    void Update()
    {
        MovePlayer();
    }
    /// <summary>
    /// Gets user input to move left or right
    /// </summary>
    private void MovePlayer()
    {
        //Get input to move Left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.left;
            //transform.position += direction * speed * Time.deltaTime;
            rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
        }

        //Get input to move Right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector3.right;
            //transform.position += direction * speed * Time.deltaTime;
            rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
        }
    }
}
