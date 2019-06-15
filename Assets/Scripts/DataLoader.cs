using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataLoader : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI actualScoreText;

    // Start is called before the first frame update
    void Start()
    {
        actualScoreText.text = LoadActualScore();
    }
    
    private string LoadActualScore()
    {
        return $"{ GameManager.GameScore }";
    }

    void Update()
    {
        actualScoreText.text = LoadActualScore();
    }
}
