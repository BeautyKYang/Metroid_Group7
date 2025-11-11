using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.CinemachineFreeLook;

/*
 * Beauty Yang
 * 11/9/25
 * Handles Regular Enemy movements and life
 */
public class RegularEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int lives = 1;

    public float leftBounds = 10f;
    public float rightBounds = 15f;
    public Vector3 moveDirection;
    public float speed = 5f;

    private void Start()
    {
        moveDirection = Vector3.left;
    }

    void Update()
    {
        transform.position += moveDirection * speed * Time.deltaTime;

        //Check if enemy reaches the left side bounds or is less than it
        if (moveDirection == Vector3.left && transform.position.x <= leftBounds)
        {
            //Enemy goes back to the right
            moveDirection *= -1;
        }

        //Check if enemy reaches the right side bounds or is greater than it
        if (moveDirection == Vector3.right && transform.position.x >= rightBounds)
        {
            //Enemy goes back to the left
            moveDirection *= -1;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //If bullet hits the enemy the enemy dies
        if (other.GetComponent<Bullets>())
        {
            print("Enemy is dead");
            DecreaseLife(); //Enemy loses a life
            Destroy(gameObject);
        }
    }

    public void DecreaseLife()
    {
        //Subtract one life
        lives--;
        enemyPrefab.SetActive(false);
    }

}