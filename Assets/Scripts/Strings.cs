using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{
    public string string1;
    public string string2;
    private string _stringsConcatenados;
    private string _unaFrase = "UNA frase con PALABRAS coherentes";

    private string _string3 = "Este es el \"string\" class"; // Uso de Comillas.


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log($"Primer string: {string1}. Tamaño: {string1.Length} caracteres.");
        //Debug.Log($"Segundo string: {string2}. Tamaño: {string2.Length} caracteres.");


        //_stringsConcatenados = string.Concat(string1, string2);
        //Debug.Log($"El resultado de la unión es: {_stringsConcatenados}");


        //Debug.Log($"Las palabras son las mismas: {string1.ToUpper().Equals(string2.ToUpper())}");
        //Debug.Log($"Las palabras son las mismas: {string1.Equals(string2)}");


        //Debug.Log("Ejemplo".Substring(2)); //Inicio
        //Debug.Log("Ejemplo".Substring(2, 9)); //Primero el Index de inicio, luego cantidad de caracteres que queremos ver (no pasarse del máximo).
        //Debug.Log("Vamos_a_reemplazar_caracteres".Replace("_", " "));
        //Debug.Log("Vamos a verificar si una subcadena es parte del string".Contains("veri"));



        //string[] arrayString = _unaFrase.Split(' ');

        //Debug.Log(arrayString.Length);

        //foreach (var item in arrayString)
        //{
        //    item.Substring(0, 1).ToUpper();
        //    Debug.Log(item);
        //}

        //Si queremos que cada letra inicial esté en mayúsucula y las siguiente en minúsucla:
        //for (int i = 0; i < arrayString.Length; i++)
        //{
        //    arrayString[i] = arrayString[i].Substring(0, 1).ToUpper() + arrayString[i].Substring(1).ToLower();
        //    Debug.Log(arrayString[i]);
        //}

        //string final = string.Join(" ", arrayString);
        //Debug.Log(final);


        //string palabrasJuntas = string.Join("_", arrayString);
        //Debug.Log(palabrasJuntas);
        //Debug.Log(palabrasJuntas.ToUpper()); //Pasa a mayúscula
        //Debug.Log(palabrasJuntas.ToLower()); //Pasa a minúscula



        //string eliminarEspacios = "     UNITY     ";
        //Debug.Log(eliminarEspacios);
        //Debug.Log(eliminarEspacios.Trim());
        //Debug.Log(eliminarEspacios);

        //eliminarEspacios = eliminarEspacios.Trim();
        //Debug.Log(eliminarEspacios);


        //string comienzo = "Verificar el comienzo";
        //Debug.Log(comienzo.StartsWith("Verificar"));
    }
}
