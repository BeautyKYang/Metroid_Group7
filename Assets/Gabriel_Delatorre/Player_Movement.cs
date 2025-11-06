using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float speed = 30f;
    
    private Vector3 direction;
    private Rigidbody rb;
    


    // Start is called before the first frame update
    void Start()
    {
        MovePlayer();
    }

    // Update is called once per frame
    void Update()
    {

        



    }

    private void MovePlayer()
    {
        //Get input to move left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            direction = Vector3.left;

            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);


        }
        //Get input to move right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector3.right;
            //transform.position += direction * speed * time.deltaTime;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);


        }




    }












}
