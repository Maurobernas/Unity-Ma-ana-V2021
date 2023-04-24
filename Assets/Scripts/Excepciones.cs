using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Excepciones : MonoBehaviour
{
    int[] numbers = new int[2];
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        //Null Reference
        //GameObject objeto = null;
        //objeto.transform.position = new Vector3 (10,10,10);

        //numbers[0] = 40;
        //numbers[1] = 17;
        //numbers[2] = 2;

        //foreach (var item in numbers)
        //{
        //    Debug.Log(item);
        //}


        try
        {
            numbers[0] = 40;
            numbers[1] = 17;
            numbers[2] = 2;

            foreach (var item in numbers)
            {
                Debug.Log(item);
            }
        }

        catch (IndexOutOfRangeException)
        {
            Debug.LogError("Ocurrió un error: índice fuera de rango");
        }

        catch (Exception ex)
        {
            Debug.LogError(ex);
            Debug.LogError("Ocurrió un error: " + ex.Message);
            Debug.LogError("Ocurrió un error: " + ex.GetType().ToString());
        }


        finally
        {
            Debug.Log("Finally");
        }


        //try
        //{
        //    Instantiate(player);
        //}
        //catch (UnassignedReferenceException)
        //{
        //    Debug.LogError("No asignaste el prefab");
        //}
    }
}
