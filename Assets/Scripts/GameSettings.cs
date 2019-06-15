using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu( fileName = "New GameSettings", menuName = "Game Settings" )]
public class GameSettings : ScriptableObject
{   
    // World Settings
    [Header("World Settings")]
    [Range(0.1f, 3f)]
    public float initialGameSpeed;

    [Range(0.01f, 0.03f)]
    public float backgroundSpeed;

    [Range(1, 10)]
    public int pointFactor = 5;

    [Range(100, 500)]
    public int columnGeneratorRate = 100;

    [Range(1, 3)]
    public int timeBetewnTransitions = 2;

    public string gameOverMessage = "OH, YOU DIE!";

    [Space]
    [Header("Player Physics")]
    [Range(9.5f, 15f)]
    public float jumpForce = 13.5f;

    [Range(5f, 9.5f)]
    public float gravityForce = 5;
}
