using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    private float _backgroundScrollSpeed;
    private Material _material;
    private Vector2 _offset;
    
    public GameSettings gameSettings;

    // Start is called before the first frame update
    void Start()
    {
        _backgroundScrollSpeed = gameSettings.backgroundSpeed;
        _material = GetComponent<Renderer>().material;
        _offset = new Vector2( _backgroundScrollSpeed, 0f );
    }

    // Update is called once per frame
    void Update()
    {
       if ( PlayerReadyDetector.IsPlayerReady == true )
        {
            _material.mainTextureOffset += _offset * Time.deltaTime;
        }
    }
}
