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

    private static int _tempScore;

    // Start is called before the first frame update
    void Start()
    {
        _tempScore = default;

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

    public static void SpeedWorldOverTime( int score )
    {
        _tempScore += score;

        if ( _tempScore == 50 )
        {
            _tempScore = default;

            GameSpeed += 1.5f;

            if ( ColumnGenerator.GeneratorRate > 5 )
            {
                ColumnGenerator.GeneratorRate -= 65;
            }
        }
    }
}
