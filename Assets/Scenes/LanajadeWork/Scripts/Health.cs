using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int life = 99;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RegularEnemy")
        {
            life -= 15;
            StartCoroutine(Blinking());
            print("you lost 15 life");
        }

        if (other.gameObject.tag == "HardEnemy")
        {
            life -= 35;
            StartCoroutine(Blinking());
            print("Hard enemy destroys u");
        }
    }

    public IEnumerator Blinking()
    {
        for (int index = 0; index < 10; index++)

        {
            if (index % 2 == 0)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
            }

            yield return new WaitForSeconds(0.25f);

        }
        GetComponent<MeshRenderer>().enabled = true;

        
    }
}
