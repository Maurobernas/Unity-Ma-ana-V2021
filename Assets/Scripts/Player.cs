using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _vida;
    [SerializeField] private float _regeneracion;
    [SerializeField] private float _danoPorTiempo;

    private int _valor;

    private float _suma;

    private void Awake()
    {
        //_valor += (int)_vida;

        //Mathf.Round(_vida);

        //Debug.Log(Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //_vida += _regeneracion * Time.deltaTime; // Suma vida
        //_vida -= _danoPorTiempo * Time.deltaTime; // Restamos vida

        RegeneracionVida();
    }

    public void RegeneracionVida()
    {
        _vida += _regeneracion * Time.deltaTime;
    }

    private int Round(int numero)
    {
        return numero;
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}

