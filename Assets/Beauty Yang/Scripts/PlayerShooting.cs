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
    public bool goingLeft;
    public bool goingRight;

    public GameObject projectilePrefab;
    public float timeBetweenShots;
    public float startDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullets", startDelay, timeBetweenShots);
    }

    public void SpawnBullet()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        if (projectile.GetComponent<Bullets>())
        {
            projectile.GetComponent<Bullets>().goingLeft = goingLeft;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
