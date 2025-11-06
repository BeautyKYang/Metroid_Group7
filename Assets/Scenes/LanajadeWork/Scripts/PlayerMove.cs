using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speed = 10f;
    public Vector3 MoveDirection;

    void Update()
    {
        //moves bucket left, stops when boundary is met
        if (Input.GetKey(KeyCode.A))
        {         
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;           
        }

        //moves bucket right, stops when boundary is met
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
    }
}
