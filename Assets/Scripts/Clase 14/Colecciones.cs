using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Dificultad
{
    Facil, Normal, Dificil
}

public enum CanvasObject
{
    BarraVida, Pausa, ContadorMonedas
}

public class Colecciones : MonoBehaviour
{
    [SerializeField] GameObject[] _gameObjects;
    private string[] _names = new string[3];

    private int[,] _numeros = new int[3, 3];


    [SerializeField] List<Transform> _transforms;

    [SerializeField] Dictionary<Dificultad, string> _dificultad = new Dictionary<Dificultad, string>();


    // Struct + Dictionary
    [SerializeField] EnumGameObject[] _canvasGO;
    [SerializeField] Dictionary<CanvasObject, GameObject> _canvas = new Dictionary<CanvasObject, GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        //_names[0] = "Unity";
        //_names[1] = "Unity2";
        //_names[2] = "Unity3";

        //_names[1] = "Unity4";

        //for (int i = 0; i  < _names.Length; i ++)
        //{
        //    Debug.Log(_names[i]);
        //}

        //Debug.Log(_names.Length);


        //for (int x = 0; x < _numeros.GetLength(0); x++)
        //{
        //    for (int y = 0; y < _numeros.GetLength(1); y++)
        //    {
        //        _numeros[x, y] = x + y;
        //        Debug.Log(_numeros[x, y]);
        //    }
        //}

        //_transforms.Add(transform);
        //_transforms.Insert(2, transform);
        //_transforms.Remove(transform);
        //_transforms.RemoveAt(0);
        //Debug.Log(_transforms.Count);

        //_dificultad.Add(Dificultad.Facil, "Facil");
        //_dificultad.Add(Dificultad.Normal, "Normal");
        //_dificultad.Add(Dificultad.Dificil, "Dificil");

        //_dificultad.Remove(Dificultad.Facil);

        //if (_dificultad.ContainsKey(Dificultad.Facil))
        //{
        //    Debug.Log(_dificultad[Dificultad.Facil]);
        //}
        //else Debug.Log("No hay llave");


        foreach (var item in _canvasGO)
        {
            if (!_canvas.ContainsKey(item._enum)) _canvas.Add(item._enum, item._object);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (_canvas[CanvasObject.BarraVida].activeInHierarchy)
            {
                _canvas[CanvasObject.BarraVida].SetActive(false);
            }
            else
            {
                _canvas[CanvasObject.BarraVida].SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (_canvas[CanvasObject.ContadorMonedas].activeInHierarchy)
            {
                _canvas[CanvasObject.ContadorMonedas].SetActive(false);
            }
            else
            {
                _canvas[CanvasObject.ContadorMonedas].SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (_canvas[CanvasObject.Pausa].activeInHierarchy)
            {
                _canvas[CanvasObject.Pausa].SetActive(false);
            }
            else
            {
                _canvas[CanvasObject.Pausa].SetActive(true);
            }
        }
    }
}


[System.Serializable]
public struct EnumGameObject
{
    public CanvasObject _enum;
    public GameObject _object;
}
