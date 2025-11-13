using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Beauty Yang
 * 11/12/25
 * Manages the Main Menu, Game, and Game Over screens
 */

public class SceneScreens : MonoBehaviour
{
    /// <summary>
    /// Returns player back to the main menu after quitting
    /// </summary>
    public void MainMenuButton(int sceneIndex)
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Opens the main game scene when the play again button is clicked
    /// </summary>
    public void PlayAgainButton(int sceneIndex)
    {
        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// Quit the game application when the quit button is clicked
    /// </summary>
    public void QuitGameButton()
    {
        //Quits a BUILD of the game, does not do anything when running the game in the editor
        Application.Quit();
        print("QUIT THE GAME");
    }
}
