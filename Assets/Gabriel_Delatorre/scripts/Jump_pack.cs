using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Jump_pack : MonoBehaviour
{
    public float jumpPack = 16f;
    private void OnTriggerEnter(Collider other)
    {

        //recognize that the player ran into the bullet pack
        if (other.tag == "Player")
        {
            //the player collects a bullet pack, the bullet pack is destroyed 
            other.GetComponent<Player_jump>().jumpForce = jumpPack;
            Destroy(gameObject);
        }
    }
}
