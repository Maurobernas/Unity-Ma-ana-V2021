using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EnumUI
{
    Life, Coins, BarraMunicion
}

public class UIController : MonoBehaviour
{
    [SerializeField] StructUI[] _uiElements;
    private Dictionary<EnumUI, GameObject> _dictionaryEnumUIGameObject = new Dictionary<EnumUI, GameObject>();

    private void Start()
    {
        foreach (var item in _uiElements)
        {
            if (!_dictionaryEnumUIGameObject.ContainsKey(item.UI)) _dictionaryEnumUIGameObject.Add(item.UI, item.Object);
        }

        GameManager.Instance.UIController = this;
    }

    public void ChangeValue(EnumUI uiobject, float value)
    {
        Debug.Log(uiobject +" " + value);
        _dictionaryEnumUIGameObject[uiobject].GetComponent<Image>().fillAmount = value;
    }

    public void ChangeText(EnumUI uiobject, string value)
    {
        _dictionaryEnumUIGameObject[uiobject].GetComponent<Text>().text = value;
    }
}

[System.Serializable]
public struct StructUI
{
    public EnumUI UI;
    public GameObject Object;
}
