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
    public PlayerMovement playerScript;
    public TMP_Text livesText;
    public TMP_Text gameOverText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + playerScript.lives;
    }
}
