using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{    
    [SerializeField] GameSettings gameSettings;

    private AudioSource _pointSound;
    private Camera _mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        _mainCamera = Camera.main;
        _pointSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D( Collider2D collision )
    {
        if ( collision.gameObject.tag.Equals( "Player" ) && GameManager.IsPlayerDeath == false )
        {
            _pointSound.Play();
            GameManager.GameScore += gameSettings.pointFactor;

            GameManager.SpeedWorldOverTime( gameSettings.pointFactor );
        }
    }
}
