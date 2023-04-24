using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image _lifeBar;
    [SerializeField] TMP_Text _text;

    public void SetLifeBar(float value)
    {
        _lifeBar.fillAmount = value;
    }

    public void SetLifeText(string value)
    {
        _text.text = value;
    }
}
