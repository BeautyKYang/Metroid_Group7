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
    public float timeBetweenShots = 0.5f;
    public float startDelay = 2f;

    private float nextFire;

    void Start()
    {
        nextFire = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //If Space is pressed, bullets will spawn
        if(Input.GetKey(KeyCode.Space))
        {
           if(Time.time >= nextFire)
            {
                print("Bullet has spawned");
                ShootingBullets();
                nextFire = Time.time + timeBetweenShots;
            }
        }
    }

   ///<summary>
   /// Player shooting bullets
   /// </summary>
   private void ShootingBullets()
   {
        //Calls bulletprefab
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        /*
        if (bullet.GetComponent<Bullets>())
        {
            bullet.GetComponent<Bullets>();
        }
        */
   }
}
