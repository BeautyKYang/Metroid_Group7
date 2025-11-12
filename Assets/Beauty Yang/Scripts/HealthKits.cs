using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

/*
 * Beauty Yang
 * 10/11/25
 * Manages the heals both regualr and full health kit gives
 */

public class HealthKits : MonoBehaviour
{
    public int maxLives = 100;
    public int life;
    public int fullHealth = 100;
    public string health = "PlayerHealth";
    public GameObject regularHealthKitPrefab;
    public GameObject fullHealthKitPrefab;

    // Start is called before the first frame update
    void Start()
    {
        life = maxLives; //Player starts will full health
    }

    private void OnTriggerEnter(Collider other)
    {
        Health playerHealth = other.GetComponent<Health>();

        //Checks if player collided with health kits
        if (playerHealth != null)
        {
            //If player touches regular health kit, their lives increase by 20
            if (other.gameObject.tag == "Regular Health Kit")
            {
                print("20 lives healed");
                int amountHealed = 20;
                IncreaseLives(amountHealed);
            }
            else if (other.gameObject.tag == "Full Health Kit") //If player touches full health kit, their max health is restored
            {
                print("Player's back in full heal");
                FullHealth();
            }
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Player lives increases by 10
    /// </summary>
    public void IncreaseLives(int amountHealed)
    {
        //Adds 20 lives to the player
        life += amountHealed;
        //Current life between 0 and maxLives
        life = Mathf.Clamp(life, 0, maxLives);
    }

    /// <summary>
    /// Sets the player to max health
    /// </summary>
    public void FullHealth()
    {
        //Brings player back to full health
        life = fullHealth;
    }
}
