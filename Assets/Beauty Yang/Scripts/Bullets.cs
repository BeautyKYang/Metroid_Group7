using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

/*
 * Beauty Yang
 * 11/6/25
 * Handles Bullets and their damage
 */
public class Bullets : MonoBehaviour
{
    public GameObject regularBulletsPrefab;
    public GameObject heavyBulletsPrefab;

    public int RegularBullets = 1;
    public int HeavyBullets = 3;

    public RegularEnemy regularEnemy;

    public int lives = 1;

    public float speed = 20f;

    private void OnTriggerEnter(Collider other)
    {

        //If bullet hits the enemy the enemy dies
        if (other.GetComponent<RegularEnemy>())
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        //Bullets will shoot straight ahead
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    /*
 * Gabriel Delatorre
 * 11/10/25
 * Handles picking up heavy Bullets 
 */
 




















}
