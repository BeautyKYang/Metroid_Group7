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
    public Vector3 spawnPoint = new Vector3 (-6.496347f, 1.534647f, -0.1221247f);

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
        Instantiate(bulletPrefab, spawnPoint, Quaternion.identity);
   }
}
