using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
   

















    private void Move()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.left;

            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);

        }



    }



}
