using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_jump : MonoBehaviour
{

    //jump force added when the player presses space
    public float jumpForce = 8f;
    //rigidbody which we will eventually add force to 
    private Rigidbody rigidBody;

    void Start()
    {
        //set the reference to the player's attached rigidBody
        rigidBody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        SpaceJump();
    }

    public void SpaceJump()
    {
        RaycastHit hit;
     //if the raycast returns true then an object has been hit and the player is touching the floor
     //For Raycast(StartPosition, RayDirection, output the object hit, maximumDistanceForTheRayCastToFire)
       
        if(Physics.Raycast(transform.position, Vector3.down, out hit, 1.5f))
        {
            Debug.Log("Touching the ground");

            

        }
        else
        {

          Debug.Log("Can't jump, not touching the ground");

        }


      //Handles Jumping 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //add an upwards velocity to the player object causing the player to jump up 
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);




        }






    }
    
    
}
