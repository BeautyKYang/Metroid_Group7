using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
Lanajade Dalman
11/12/25
manages health and health kits
*/
public class Health : MonoBehaviour
{
    public int life = 99;
    public bool isBlinking = false;
    public int amountHealed = 20;

    /// <summary>
    /// if player dies
    /// </summary>
    private void Update()
    {
        if (life == 0)
        {
            //sends to end game
            SceneManager.LoadScene(2);
        }
    }

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

    /// <summary>
    /// regular health pack functions
    /// </summary>
    public void RegHeal()
    {
        if (life < 99)
        {
            //life gets healed
            life += amountHealed;
            print("you healed " + amountHealed + " life!");

            //makes sure that life does not exceed 99
            if (life > 99)
            {
                life = 99;
            }
            
            print("Life: " + life);
        }
        //life does not exceed 99
        else if (life == 99)
        {
            print("You have full health!");
        }
    }

    /// <summary>
    /// full health pack
    /// </summary>
    public void FullHeal()
    {
        //max life adds 100 and life is fully healed
        life = 99;
        life += 100;
    }

    /// <summary>
    /// blinks when damaged
    /// </summary>
    /// <returns></returns>
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
