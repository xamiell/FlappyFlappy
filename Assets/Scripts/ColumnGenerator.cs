using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnGenerator : MonoBehaviour
{
    private struct YPositions
    {
        public const float YPOSMIN = -2f;
        public const float YPOSMAX = 2f;
    }

    public static int GeneratorRate;

    [SerializeField] GameSettings gameSettings;
    [SerializeField] GameObject columns;
    [SerializeField] Transform wall;

    private GameObject _currentColumns;

    private int _frameCounter = default;

    // Start is called before the first frame update
    void Start()
    {
        GeneratorRate = gameSettings.columnGeneratorRate;
    }

    // Update is called once per frame
    void Update()
    {
        _frameCounter = ( _frameCounter.Equals( GeneratorRate ) ) ? _frameCounter = default : _frameCounter + 1;

        if ( PlayerReadyDetector.IsPlayerReady && _frameCounter.Equals( GeneratorRate ) )
        {
            _currentColumns = Instantiate( columns, new Vector3( gameObject.transform.position.x, Random.Range( YPositions.YPOSMIN, YPositions.YPOSMAX ), 
                gameObject.transform.position.z ), Quaternion.identity ) as GameObject;
        }
    }
}
