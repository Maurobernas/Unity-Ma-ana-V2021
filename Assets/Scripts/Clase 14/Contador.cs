using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    private int _coins;

    private void Start()
    {
        GameManager.Instance.Contador = this;
    }

    public int Coins { get { return _coins; } set { _coins = value; } }
}
