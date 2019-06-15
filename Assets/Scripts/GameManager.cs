using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerScore;
    [SerializeField] GameSettings gameSettings;

    public static int GameScore;
    public static bool IsPlayerDeath;
    public static float GameSpeed;

    // Start is called before the first frame update
    void Start()
    {
        IsPlayerDeath = false;
        GameSpeed = gameSettings.initialGameSpeed;

        // Reset static property score
        GameScore = default;
    }

    // Update is called once per frame
    void Update()
    {
        if ( IsPlayerDeath )
        {
            PlayerReadyDetector.IsPlayerReady = false;
            
        }
        
        playerScore.text = GameScore.ToString();
    }

    public static void PlayerDie()
    {
        IsPlayerDeath = true;
        PlayerReadyDetector.IsPlayerReady = false;
    }
}
