using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMovement : MonoBehaviour
{
    [SerializeField] GameSettings gameSettings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( PlayerReadyDetector.IsPlayerReady )
        {
            transform.Translate( Vector2.left * GameManager.GameSpeed * Time.deltaTime );
        }
    }
}
