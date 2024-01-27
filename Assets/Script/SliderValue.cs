using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValue : MonoBehaviour
{
    public TMP_Text TextValue;
    public Slider Slider;


    public void OnValueChanged(float newValue)
    {
        int valueInt = (int)Mathf.Round(newValue * 100.0f);
        TextValue.text = valueInt.ToString();
    }
}
