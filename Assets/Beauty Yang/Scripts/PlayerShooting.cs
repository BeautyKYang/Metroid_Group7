using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Beauty Yang
 * 10/30/25
 * Handles the Player's shooting movements
 */

public class PlayerShooting : MonoBehaviour
{

    public GameObject projectilePrefab;
    public float timeBetweenShots;
    public float startDelay;

    public float speed = 10f;
    public float jumpForce = 8f;
    public float groundCheckDist = 1.2f;

    public Vector3 direction;
    private Rigidbody rb;

    
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnBullets", startDelay, timeBetweenShots);
        rb = GetComponent<Rigidbody>();
    }

    public void SpawnBullet()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        if (projectile.GetComponent<Bullets>())
        {
            projectile.GetComponent<Bullets>();
        }
    }

    // Update is called once per frame
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
        if (Input.GetKey(KeyCode.Space))
        {
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }

        //REFERENCE
        //Get input to move Right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector3.right;
            //transform.position += direction * speed * Time.deltaTime;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }
    }
}
