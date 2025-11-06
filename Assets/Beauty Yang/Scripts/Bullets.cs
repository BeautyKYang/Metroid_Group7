using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class Bullets : MonoBehaviour
{
    public GameObject regularBulletsPrefab;
    public GameObject heavyBulletsPrefab;

    public int RegularBullets = 1;
    public int HeavyBullets = 3;

    public RegularEnemy regularEnemy;

    public int lives = 1;

    private void OnTriggerEnter(Collider other)
    {

        //If bullet hits the enemy the enemy dies
        if (other.GetComponent<RegularEnemy>())
        {
            Destroy(gameObject);
        }
    }
}
