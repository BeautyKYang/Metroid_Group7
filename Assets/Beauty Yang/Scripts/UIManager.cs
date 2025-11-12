using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/*
 * Beauty Yang
 * 11/10/25
 * Manages and caluclates the player's health decreasing and increasing
 */
public class UIManager : MonoBehaviour
{
    public Health playerHealth;
    public TMP_Text livesText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + playerHealth.life;
    }
}
