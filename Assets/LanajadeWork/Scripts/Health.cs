using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int life = 99;
    public bool isBlinking = false;
    public int amountHealed = 20;

    void OnTriggerEnter(Collider other)
    {
        if (isBlinking)
        {
            print("invincible while blinking");
        }
        else
        {
            if (other.gameObject.tag == "RegularEnemy")
            {
                life -= 15;
                StartCoroutine(Blinking());
                print("you lost 15 life");
                print("u now have " + life + " life.");
            }

            if (other.gameObject.tag == "HardEnemy")
            {
                life -= 35;
                StartCoroutine(Blinking());
                print("Hard enemy does 35 damage.");
                print("u now have " + life + " life.");
            }

            if (other.gameObject.tag == "Regular Health Kit")
            {
                RegHeal();
            }

            if (other.gameObject.tag == "Full Health Kit")
            {
                FullHeal();
            }
        }
    }

    public void RegHeal()
    {
        if (life < 99)
        {
            life += amountHealed;
        }
        else
        {
            print("You have full health!");
        }
    }

    public void FullHeal()
    {
        life = 99;
        life += 100;
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
            isBlinking = true;
        }
        GetComponent<MeshRenderer>().enabled = true;
        isBlinking = false;
    }
}
