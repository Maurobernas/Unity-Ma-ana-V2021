using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public enum EnumTest
{
    A,B,C
}

public class UiTest : MonoBehaviour
{
    //[SerializeField] TMP_Text _tittle;
    private int _option;
    private EnumTest _actualOption;
    private string _code = "contraseña";

    // Start is called before the first frame update
    void Start()
    {
        //_tittle.text = "NUEVO TÍTULO";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeOption(int option)
    {
        _option = option;
    }

    public void TestToggle(bool toggle)
    {
        Debug.Log("Se modificó la opción: " + _option + ". Ahora su valor es: " + toggle);
        // Lógica para cambiar opción.
    }

    public void TestSlider(float value)
    {
        Debug.Log(value);
    }

    public void TestDropdown(int option)
    {
        _actualOption = (EnumTest)option;
        Debug.Log(_actualOption);
    }


    public void TestCode(string code)
    {
        if(code.ToLower() == _code)
        {
            Debug.Log("Ganaste");
        }
        else
        {
            Debug.Log("Error");
        }
    }


    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    

    // Cerrar el juego
    public void Exit()
    {
        Application.Quit();
    }
}
