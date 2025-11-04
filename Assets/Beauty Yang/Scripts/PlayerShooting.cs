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
    public GameObject bulletPrefab;
    public Vector3 spawnPoint = new Vector3 (0f, 0f, 0f);
    public float spawnRate = 1f;

    public float timeBetweenShots = 1f;
    public float startDelay = 2f;

    private void Start()
    {
        //InvokeRepeating("ShootingBullets", );
    }

    // Update is called once per frame
    void Update()
    {
        //If Space is pressed, bullets will spawn
        if(Input.GetKey(KeyCode.Space))
        {
            print("Bullet has spawned");
            ShootingBullets();
        }
    }

   ///<summary>
   /// Player shooting bullets
   /// </summary>
   private void ShootingBullets()
   {
        //Calls bulletprefab
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        bulletPrefab.SetActive(true);
   }
}
