using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButtons : MonoBehaviour
{
    public void OnStartGame()
    {
        PlayerReadyDetector.IsPlayerReady = true;
    }

    public void OnQuitGame()
    {
        Application.Quit();
    }
}
