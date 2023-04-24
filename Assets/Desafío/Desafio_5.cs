using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject[] trees = GameObject.FindGameObjectsWithTag("Trees");
        foreach (GameObject tree in trees)
        {
            Debug.Log("Nombre: " + tree.name + " Posicion: " + tree.transform.position);
        }

        GameObject[] branches = GameObject.FindGameObjectsWithTag("Branches");
        for (int i = 0; i < branches.Length; i++)
        {
            branches[i].transform.localScale = new Vector3(10, 10, 10);
        }

        GameObject[] grass = GameObject.FindGameObjectsWithTag("Grass");
        int j = 0;
        while (j < grass.Length)
        {
            grass[j].SetActive(false);
            j++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// Autores: Bruque Lopez Damian Alejandro, Bravo Camila, Ramos Cecilia
// Fecha: 16-4-2023
// Descripción: Desafio 5 - Estructuras de control
// Lenguaje: csharp
// Path: Desafio_5.cs