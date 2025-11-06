using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.CinemachineFreeLook;
using static Cinemachine.DocumentationSortingAttribute;

public class Bullets : MonoBehaviour
{
    public GameObject regularBulletsPrefab;

    public int RegularBullets = 1;

    /*
    public void DecreaseLives()
    {
        //Subtract one life
        lives--;

        if (lives == 2) //1 life lost - disable first bucket
            enemy.SetActive(false);
        else if (lives == 1) //2 life lost - disable second bucket
            enemy.SetActive(false);
        else //3 life lost - disable third bucket
        {
            enemy.SetActive(false);

            //Load game over screen
            SceneManager.LoadScene(2); //Or use: StartCoroutine(WaitToLoadGameOver(2f));
        }
    }
    */
}
