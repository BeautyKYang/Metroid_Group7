using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int life = 99;

    [Header("MaterialBlinkDMG")]
    public Material newMaterial;
    private MeshRenderer meshRenderer;

    void Start()
    {
        // Get the MeshRenderer component attached to this GameObject
        meshRenderer = GetComponent<MeshRenderer>();
    }
}
