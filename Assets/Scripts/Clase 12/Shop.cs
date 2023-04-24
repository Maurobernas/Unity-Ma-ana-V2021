using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] float _itemValue;

    public void Compra(float gold)
    {

    }

    public void Compra(ref float gold, float vida = 1)
    {
        if(gold >= _itemValue)
        {
            gold = _itemValue;
            Debug.Log(gold);
            Debug.Log("Comprado");
        }

        else
        {
            Debug.Log("Compra rechazada");
        }
    }

    public void Compra (float gold, float descuento)
    {

    }

    public void Compra(string arma)
    {

    }

    public void Compra(params string[] armas)
    {
        foreach (var item in armas)
        {
            Debug.Log("Compró un: " + item);
        }
    }
}
