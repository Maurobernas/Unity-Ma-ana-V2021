using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaAleatorio : MonoBehaviour
{
    [SerializeField] private int _x;
    [SerializeField] private int _y;
    [SerializeField] GameObject[] _terreno;

    // Start is called before the first frame update
    void Start()
    {
        //int[,] gameObjects = new int[_x, _y];

        //for (int x = 0; x < gameObjects.GetLength(0); x++)
        //{
        //    for (int y = 0; y < gameObjects.GetLength(1); y++)
        //    {
        //        int numeroRandom = Random.Range(0, 4);

        //        switch (numeroRandom)
        //        {
        //            case 0:
        //                Instantiate(_terreno[0], new Vector3(x, -0.5f, y), Quaternion.identity);
        //                break;
        //            case 1:
        //                Instantiate(_terreno[1], new Vector3(x, -0.5f, y), Quaternion.identity);
        //                break;
        //            case 2:
        //                Instantiate(_terreno[2], new Vector3(x, -0.5f, y), Quaternion.identity);
        //                break;
        //            case 3:
        //                Instantiate(_terreno[3], new Vector3(x, -0.5f, y), Quaternion.identity);
        //                break;
        //        }
        //    }
        //}


        int[,] gameObjects = new int[_x, _y];

        for (int x = 0; x < gameObjects.GetLength(0); x++)
        {
            for (int y = 0; y < gameObjects.GetLength(1); y++)
            {
                int numeroRandom = Random.Range(0, 4);

                Instantiate(_terreno[numeroRandom], new Vector3(x, -0.5f, y), Quaternion.identity);
            }
        }
    }
}
