using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get { return _instance; } }
    private static GameManager _instance;

    private Contador _contador;

    private UIController _uiController;

    private void Awake()
    {
        if (_instance == null) _instance = this;
        else Destroy(this);
    }

    public Contador Contador { get { return _contador; } set { _contador = value; } }
    public UIController UIController { get { return _uiController; } set { _uiController = value; } }
}
