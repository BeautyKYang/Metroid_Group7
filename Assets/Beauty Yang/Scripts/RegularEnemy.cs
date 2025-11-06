using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.CinemachineFreeLook;

public class RegularEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int lives = 1;

    public Transform leftPoint;
    public Transform rightPoint;
    public float speed = 5;

    private Vector3 direction;
    private Vector3 startLeftpos;
    private Vector3 startRightpos;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.left;
        startLeftpos = leftPoint.position;
        startRightpos = rightPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += direction * speed * Time.deltaTime;

        //Check if enemy has reached the left point to turn around
        if (transform.position.x <= startLeftpos.x) // other way to code: (direction == Vector3.left && transform.position.x <= startLeftpos.x) //== is comparing the values of the variables
        {
            direction = Vector3.right;
        }
        else if (transform.position.x >= startRightpos.x) //Check if enemy has reached the right point to turn around
        {
            direction = Vector3.left;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //If bullet hits the enemy the enemy dies
        if (other.GetComponent<Bullets>())
        {
            lives--; //Enemy loses a life
            Destroy(other.gameObject);
        }
    }
}