using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameSettings gameSettings;

    private Rigidbody2D _playerRigidbody2D;
    private Animator _playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        _playerAnimator = GetComponent<Animator>();
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (( Input.GetKeyDown( KeyCode.Mouse0 ) || Input.GetKeyDown( KeyCode.Space )) && PlayerReadyDetector.IsPlayerReady && GameManager.IsPlayerDeath == false )
        {
            Jump();
        }

        if ( PlayerReadyDetector.IsPlayerReady )
        {
            _playerAnimator.SetBool("IsPlayerReady", true);
        }
    }

    private void Jump()
    {
        if ( _playerRigidbody2D.gravityScale != gameSettings.gravityForce )
        {
            OnReadyPlayer();
        }

        _playerRigidbody2D.velocity = Vector2.up * gameSettings.jumpForce;
    }

    private void OnReadyPlayer()
    {
        _playerRigidbody2D.gravityScale = gameSettings.gravityForce;
    }

    // When the player is hit the animation is trigger.
    private void OnTriggerEnter2D( Collider2D collision )
    {
        if ( collision.gameObject.tag.Equals( "Panel" ) )
        {
            _playerAnimator.SetTrigger( "Hit" );

            GameManager.PlayerDie();
        }
    }
}
