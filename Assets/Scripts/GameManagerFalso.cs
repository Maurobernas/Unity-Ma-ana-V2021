using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerFalso : MonoBehaviour
{
    [SerializeField] GameObject[] _gameObjects;
    [SerializeField] Transform[] _transforms;
    [SerializeField] Color _color;
    [SerializeField] LineRenderer _lineRenderer;
    [SerializeField] float _timer;
    [SerializeField] PlayerMovement _player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if(_timer <= 0)
        {
            foreach (var item in _gameObjects)
            {
                //item.SetActive(false);
                Destroy(item);
            }
        }
    }
}
