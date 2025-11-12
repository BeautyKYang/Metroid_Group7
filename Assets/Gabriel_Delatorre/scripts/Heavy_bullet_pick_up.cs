using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Gabriel
 * 11/10/25
 * Handles picking up heavy Bullet packs and changes regular bullet to heavy ones
 */
public class Heavy_bullet_pick_up : MonoBehaviour
{
    public GameObject heavyBullet;
    private void OnTriggerEnter(Collider other)
    {

        //recognize that the player ran into the bullet pack
        if (other.tag == "Player")
        {
            //the player collects a bullet pack, the bullet pack is destroyed 
            other.GetComponent<PlayerShooting>().regularBulletPrefab = heavyBullet;
            Destroy(gameObject);
        }
    }











}
