using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;
/*
Lanajade Dalman
11/12/25
teleports player to another level
 */
public class Portal : MonoBehaviour
{
    public GameObject spawnPoint;
    private Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            startingPosition = spawnPoint.transform.position;
            other.gameObject.transform.position = startingPosition;
        }
    }
}
